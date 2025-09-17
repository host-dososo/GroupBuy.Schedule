using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.Entites;
using GroupBuy.Schedule.Models.Schedule;
using GroupBuy.Schedule.Models.Schedule.Service;
using GroupBuy.Schedule.Services.Jobs;
using Hangfire;
using Hangfire.Server;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using Microsoft.EntityFrameworkCore;
using NCrontab;
using Newtonsoft.Json.Linq;
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
    public class JobService : Base
    {
        public ScheduleService? _scheduleService;
        public int _merchantId;
        public int _userId;

        public JobService(ScheduleService scheduleService) {
            _scheduleService = scheduleService;
        }

        public void SetUserInfo(int merchantId, int userId) {
            _merchantId = merchantId;
            _userId = userId;
        }

        public void ExecuteJob(PerformContext context,ScheduleName scheduleName, string? payload, ExecuteJobOption? option = null)
        {
            try
            {
                LogService.WriteJsonLog("ExecuteJob", $"ScheduleName:{scheduleName}, payload:{payload}");
                var fbJob = new FBJob(_merchantId, _userId);
                var lineJob = new LineJob(_merchantId,_userId);
                var merJob = new MerJob();
                EmitExecutingJob(scheduleName, payload,context);
                switch (scheduleName)
                {
                    case ScheduleName.CreatePostToSoc:
                        lineJob.CreatePost(payload!, context.BackgroundJob.Id);
                        fbJob.CreatePost(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.FBAsyncOrder:
                        fbJob.FBAsyncOrder(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.SupplyGoods:
                        merJob.SupGooToMer(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.SysErrorLogSendMail:
                        var sysJob = new SysJob();
                        sysJob.ErrorLogSendMail(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.UpdateFBPost:
                        fbJob.UpdatePost(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.UpdateLinePost:
                        lineJob.UpdatePost(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.DeleteFBPost:
                        fbJob.DeletePost(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.DeleteLinePost:
                        lineJob.DeletePost(payload!, context.BackgroundJob.Id);
                        break;
                    case ScheduleName.ValidMessengerUIDWrited:
                        merJob.ValidWriteUID(payload!);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                

            }
            catch (Exception ex) {
                LogService.AddLog(ex);
            }
        }

        public void DelayExecuteJob(PerformContext context, ScheduleName scheduleName, string? payload, TimeSpan delay, ExecuteJobOption? option) {
            var addResult = _scheduleService?.AddDelayedJob(() => ExecuteJob(null!, scheduleName, payload, option), delay);
            var recurringJobId = option?.RecurringJobId ?? null;
            var msj = db.MerSchedJob.FirstOrDefault(j => j.JobId == context.BackgroundJob.Id);
            if (string.IsNullOrEmpty(recurringJobId))
            {
                context.BackgroundJob.ParametersSnapshot.TryGetValue("RecurringJobId", out recurringJobId);
                recurringJobId = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(recurringJobId);
            }
            //LogService.logger.LogInformation()

            if (msj == null)
            {
                msj = db.MerSchedJob.FirstOrDefault(j => j.HashKey == recurringJobId);
                if (msj != null)
                {
                    var newMsj = DataService.MergeData<MerSchedJob>(msj);
                    newMsj.JobId = addResult.JobId;
                    newMsj.Id = 0;
                    newMsj.Result = null;
                    newMsj.CreatedTime = DateTime.Now;
                    db.MerSchedJob.Add(newMsj);
                    db.SaveChanges();
                }
            }
            else {
                msj.JobId = addResult.JobId;
                db.SaveChanges();
            }

        }

        public static TimeSpan ConvertCronToTimeSpan(string cronExpression)
        {
            var schedule = CrontabSchedule.Parse(cronExpression);
            DateTime now = DateTime.UtcNow;
            DateTime nextRun = schedule.GetNextOccurrence(now);
            DateTime afterNextRun = schedule.GetNextOccurrence(nextRun);

            return afterNextRun - nextRun;
        }


    }
}
