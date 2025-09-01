using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.Schedule;
using GroupBuy.Schedule.Models.Schedule.Service;
using Hangfire;
using Hangfire.Storage;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace GroupBuy.Schedule.Services
{
    public class ScheduleService : Base
    {
        private readonly IBackgroundJobClient _backgroundJobClient;
        private ScheduleName _scheduleName;
        private string _payload;

        public ScheduleService(IBackgroundJobClient backgroundJobClient)
        {
            _backgroundJobClient = backgroundJobClient;
        }

        public void SetDefaultInfo(ScheduleName scheduleName, string payload) {
            _scheduleName = scheduleName;
            _payload = payload;
        }

        // 即時執行任務
        public AddResult AddFireAndForgetJob(Expression<Action> taskMethod)
        {
            var addResult = new AddResult();
            addResult.JobId = _backgroundJobClient.Enqueue(taskMethod);
            var monitoringApi = JobStorage.Current.GetMonitoringApi();
            var jobDetails = monitoringApi.JobDetails(addResult.JobId);
            addResult.ExpireAt = jobDetails.ExpireAt;
            EmitAddedJob(_scheduleName, _payload);
            return addResult;
        }

        // 定期執行任務（使用 Cron 表達式）
        public AddResult AddRecurringJob(string? id = null,Expression<Action> taskMethod = null!, string cronExpression = null!)
        {
            if (string.IsNullOrEmpty(id)) {
                id = MathService.GenRandomNumber(12);
            }
            if (string.IsNullOrEmpty(cronExpression))
            {
                throw new ArgumentException("Cron expression must be provided for recurring jobs.");
            }
            var addResult = new AddResult();
            addResult.JobId = id;
            RecurringJob.AddOrUpdate(id, taskMethod, cronExpression,new RecurringJobOptions(){ 
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time") // 設定為台灣時區 
            });
            var monitoringApi = JobStorage.Current.GetMonitoringApi();
            EmitAddedJob(_scheduleName, _payload);
            return addResult;
        }

        // 延遲執行任務（根據延遲時間）
        public AddResult AddDelayedJob(Expression<Action> taskMethod, TimeSpan delay)
        {
            var addResult = new AddResult();
            addResult.JobId = _backgroundJobClient.Schedule(taskMethod, delay);
            var monitoringApi = JobStorage.Current.GetMonitoringApi();
            var jobDetails = monitoringApi.JobDetails(addResult.JobId);
            addResult.ExpireAt = jobDetails.ExpireAt;
            EmitAddedJob(_scheduleName, _payload);
            return addResult;
        }

        // 延遲到指定時間執行任務（根據指定時間）
        public AddResult AddDelayedToTimeJob(Expression<Action> taskMethod, DateTime executeAt)
        {
            var addResult = new AddResult();

            addResult.JobId = _backgroundJobClient.Schedule(taskMethod, executeAt);
            var monitoringApi = JobStorage.Current.GetMonitoringApi();
            var jobDetails = monitoringApi.JobDetails(addResult.JobId);
            addResult.ExpireAt = jobDetails.ExpireAt;
            EmitAddedJob(_scheduleName, _payload);
            return addResult;
        }

        public bool IsRecurringJob(string jobId)
        {
            using (var connection = JobStorage.Current.GetConnection())
            {
                var recurringJobs = connection.GetRecurringJobs();
                return recurringJobs.Any(j => j.Id == jobId);
            }
        }

        public bool IsBackgroundJob(string jobId)
        {
            var jobDetails = JobStorage.Current.GetMonitoringApi().JobDetails(jobId);
            return jobDetails != null;
        }

        public bool DeleteJob(string jobId) {
            var isSuc = false;
            if (IsRecurringJob(jobId))
            {
                RecurringJob.RemoveIfExists(jobId);
                Console.WriteLine($"Recurring Job {jobId} 已刪除");
                isSuc = true;
            }
            else if (IsBackgroundJob(jobId))
            {
                isSuc = BackgroundJob.Delete(jobId);
                Console.WriteLine($"Background Job {jobId} 已刪除");
            }
            else
            {
                Console.WriteLine($"Job {jobId} 不存在或已執行");
            }
            return isSuc;
        }
    }
}
