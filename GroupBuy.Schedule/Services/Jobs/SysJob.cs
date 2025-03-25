
using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models.FBJob.Query;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Services.Repos;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using GroupBuy.Schedule.Models.Entites;

namespace GroupBuy.Schedule.Services.Jobs
{
    public class SysJob
    {
        private string host = AppSettingService.Get("MerBaseUri");
        public SysJob() {
            
        }

        public async Task<ServiceResult<object>> ErrorLogSendMail(string reqStr, string jobId)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                using (var sbHttp = new MyHttpService(host))
                {
                    sw.Start();
                    LogService.WriteJsonLog("ErrorLogSendMail", new { type = "START_REQUEST" });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("sys/error_log_send_mail", new {});
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    //sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("ErrorLogSendMail", new { type = "END_REQUEST", response, executedTime = elapsedTime });
                }
            }
            catch (Exception ex)
            {
                // 停止計時
                sw.Stop();
                LogService.AddLog(ex);
                sr.SetResult(ex);
            }
            return sr;
        }
    }
}
