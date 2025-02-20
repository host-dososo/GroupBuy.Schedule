
using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.FBJob.Query;
using GroupBuy.Schedule.Services.Repos;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace GroupBuy.Schedule.Services.Jobs
{
    public class FBJob : Base
    {
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        private string host = AppSettingService.Get("MerBaseUri");
        public FBJob()
        {
            var url = AppSettingService.Get("MerBaseUri");
            // 這裡填寫你的 ASP.NET MVC 伺服器端的 SignalR URL
            _connection = new HubConnection(Path.Combine(url, "signalr"));
            // 指定要連接的 Hub 名稱，假設伺服器端有一個 "ChatHub"
            _hubProxy = _connection.CreateHubProxy(SignalRKeys.Hub.FBHub);
        }

        /// <summary>
        /// 透過貼文編號取得所有留言
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="commentId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ServiceResult<object>> FBAsyncOrder(string reqStr, string jobId)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                var req = JsonConvert.DeserializeObject<FBAsyncOrderRequestWithNotice>(reqStr);
                req!.JobId = jobId;

                using (var sbHttp = new MyHttpService(host))
                {
                    // 更新通知
                    //var notice = db.MerNotice.FirstOrDefault(n => n.Id == req.MerNoticeId);
                    //if (notice != null)
                    //{
                    //    notice.Data = JsonConvert.SerializeObject(new { JobId = jobId });
                    //    db.SaveChanges();
                    //}

                    var apiReq = DataService.MergeData<FBAsyncOrderRequest>(req);
                    sw.Start();
                    LogService.WriteJsonLog("FBAsyncOrder", new { type = "START_REQUEST", apiReq });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("soc/fb/asyncOrder", apiReq);
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    
                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    //sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("GetGroupInfo", new { type = "END_REQUEST", req, response, executedTime = elapsedTime });

                    await _connection.Start();
                    await _hubProxy.Invoke(SignalRKeys.FBSelfbot.ScheduleEnqueqed, jobId, response);
                    _connection.Stop();
                }
              
            }
            catch (Exception ex)
            {
                // 停止計時
                sw.Stop();
                LogService.AddLog(ex);
                sr.SetResult(ex);
                var msjService = new MerSchedJobService();
                msjService.UpdateResult(jobId, sr);
            }
            return sr;
        }
    }
}
