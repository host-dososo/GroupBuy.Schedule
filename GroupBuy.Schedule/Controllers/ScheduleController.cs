using Azure.Core;
using GroupBuy.Schedule.Models.Schedule;
using GroupBuy.Schedule.Models.Schedule.Api;
using GroupBuy.Schedule.Models.Schedule.Service;
using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Services.Repos;
using Hangfire;
using Hangfire.Storage;
using Hangfire.Storage.Monitoring;
using Microsoft.AspNetCore.Mvc;
using NCrontab;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;
using System.Text.Json;

namespace GroupBuy.Schedule.Controllers
{
    [ApiController]
    public class ScheduleController : BasicController
    {
        private readonly ScheduleService _scheduleService;
        private readonly JobService _jobService;

        public ScheduleController(ScheduleService scheduleService,JobService jobService)
        {
            _scheduleService = scheduleService;
            _jobService = jobService;
        }

        [HttpPost]
        public async Task<ApiResult<ScheduleAddResponse?>> Add(ScheduleAddRequest req)
        {
            var ar = new ApiResult<ScheduleAddResponse?>(ApiResult.Action.新增);
            var sr = new ScheduleAddResponse();
            try
            {
                Enum.TryParse(req.ScheduleName, out ScheduleName scheduleName);
                AddResult? addResult = null;
                // 根據傳入的 ScheduleName 決定執行哪一種排程方式
                switch (req.ScheduleType)
                {
                    case ScheduleType.FireAndForget:
                        addResult = _scheduleService.AddFireAndForgetJob(() => _jobService.ExecuteJob(null!, scheduleName, req.Payload,null));
                        sr = DataService.MergeData<ScheduleAddResponse>(addResult);
                        break;

                    case ScheduleType.Recurring:
                        // 定期執行任務（使用 Cron 表達式）
                        if (string.IsNullOrEmpty(req.CronExpression))
                        {
                            throw new ArgumentException("Cron expression must be provided for recurring jobs.");
                        }
                        // 解析 Cron 表達式
                        var schedule = CrontabSchedule.Parse(req.CronExpression);
                        DateTime nextRun = schedule.GetNextOccurrence(DateTime.Now);

                        // 計算剩餘時間
                        TimeSpan lastTimeUntilNextRun = JobService.ConvertCronToTimeSpan(req.CronExpression);
                        TimeSpan timeUntilNextRun = nextRun - DateTime.Now;
 
                        var recurringAddResult = _scheduleService.AddRecurringJob(null,
                            () => _jobService.DelayExecuteJob(null!, scheduleName, req.Payload, lastTimeUntilNextRun,null)
                            , req.CronExpression);
                        addResult = _scheduleService.AddFireAndForgetJob(() => _jobService.DelayExecuteJob(null!, scheduleName, req.Payload, timeUntilNextRun,new ExecuteJobOption { 
                            RecurringJobId = recurringAddResult.JobId
                        }));
                        addResult.RecurringJobId = recurringAddResult.JobId;
                        sr = DataService.MergeData<ScheduleAddResponse>(addResult);
                        break;

                    case ScheduleType.Delayed:
                        // 延遲執行任務
                        if (req.DelayInMinutes == null || req.DelayInMinutes == 0)
                        {
                            throw new ArgumentException("Delay time must be provided for delayed jobs.");
                        }
                        TimeSpan delay = TimeSpan.FromMinutes((int)req.DelayInMinutes);
                        addResult = _scheduleService.AddDelayedJob(() => _jobService.ExecuteJob(null!, scheduleName, req.Payload, null), delay);
                        sr = DataService.MergeData<ScheduleAddResponse>(addResult);
                        break;

                    case ScheduleType.DelayedToTime:
                        // 延遲到指定時間執行任務
                        if (req.ExecuteAt == null)
                        {
                            throw new ArgumentException("Execute time must be provided for delayed to time jobs.");
                        }
                        addResult = _scheduleService.AddDelayedToTimeJob(() => _jobService.ExecuteJob(null!, scheduleName, req.Payload, null), (DateTime)req.ExecuteAt);
                        sr = DataService.MergeData<ScheduleAddResponse>(addResult);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                    
                }

                ar.SetResult(sr);
            }
            catch (Exception ex)
            {
                ar.SetResult(ex);
            }
            return ar;
        }

        [HttpPost]
        public async Task<ApiResult<ScheduleEditResponse?>> Edit(ScheduleEditRequest req)
        {
            var ar = new ApiResult<ScheduleEditResponse?>(ApiResult.Action.編輯);
            var sr = new ScheduleEditResponse();
            try
            {
                //Enum.TryParse(req.ScheduleName, out ScheduleName scheduleName);
                var monitoringApi = JobStorage.Current.GetMonitoringApi();
                var jobDetails = monitoringApi.JobDetails(req.JobId);
                ar.CheckToException(jobDetails == null, "找不到該排程任務");
                var args = jobDetails.Job.Args.ToList();
                ar.CheckToException(req.ExecuteAt == null, "請指派執行時間");
                AddResult? addResult = null;

                addResult = _scheduleService.AddDelayedToTimeJob(() => _jobService.ExecuteJob(null!, (ScheduleName)args[1], (string?)args[2], (ExecuteJobOption?)args[3]), (DateTime)req.ExecuteAt);
                sr = DataService.MergeData<ScheduleEditResponse>(addResult);
                
                _scheduleService.DeleteJob(req.JobId);
           

                ar.SetResult(sr);
            }
            catch (Exception ex)
            {
                ar.SetResult(ex);
            }
            return ar;
        }

        [HttpPost]
        public async Task<ApiResult<ScheduleRemoveResponse?>> Remove(ScheduleRemoveRequest req)
        {
            var ar = new ApiResult<ScheduleRemoveResponse?>(ApiResult.Action.刪除);
            var sr = new ScheduleRemoveResponse();
            try
            {
                sr.IsSuc = _scheduleService.DeleteJob(req.JobId);
                if (req.WithRecurringJob) {
                    var monitoringApi = JobStorage.Current.GetMonitoringApi();
                    var jobDetails = monitoringApi.JobDetails(req.JobId);
                    var msjService = new MerSchedJobService();
                    var msj = msjService.GetOne(req.JobId)?.Data;

                    if (msj != null && !string.IsNullOrEmpty(msj.HashKey)) {
                        sr.IsSuc = _scheduleService.DeleteJob(msj.HashKey) && sr.IsSuc;
                    }
                }
                ar.SetResult(sr);
            }
            catch (Exception ex)
            {
                ar.SetResult(ex);
            }
            return ar;
        }
    }
}
