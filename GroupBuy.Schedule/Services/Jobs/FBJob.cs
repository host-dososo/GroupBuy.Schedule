
using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Models.FBJob.Query;
using GroupBuy.Schedule.Models.Schedule;
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
        public FBJob() : this(0, 0)
        {
            (_connection, _hubProxy) = InitConnection(0, 0);
        }

        public FBJob(int merchantId, int userId) : base(merchantId, userId)
        {
            (_connection, _hubProxy) = InitConnection(merchantId, userId);
        }

        public (HubConnection, IHubProxy) InitConnection(int merchantId, int userId)
        {
            var url = AppSettingService.Get("MerBaseUri");
            var newQuery = new Dictionary<string, string>
               {
                   { "userId", userId.ToString() },
                   { "merchantId", merchantId.ToString() }
               };
            var connection = new HubConnection(Path.Combine(url, "signalr"), newQuery);
            var hubProxy = connection.CreateHubProxy(SignalRKeys.Hub.FBHub);
            return (connection, hubProxy);
        }

        public async void CreatePost(string payload, string jobId)
        {
            try
            {
                // 開始連接
                await _connection.Start();
                JObject objPayload = JObject.Parse(payload);
                if (!string.IsNullOrEmpty(jobId))
                {
                    objPayload.Add("jobId", jobId);
                }
                await _hubProxy.Invoke(SignalRKeys.MerUsr.CreatePost, objPayload);
            }
            catch (Exception ex)
            {
                LogService.AddLog(ex);
            }
        }
        /// <summary>
        /// 透過貼文編號取得所有留言
        /// </summary>
        /// <param name="reqStr"></param>
        /// <param name="jobId"></param>
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
                    sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("FBAsyncOrder", new { type = "END_REQUEST", req, response, executedTime = elapsedTime });

                    await _connection.Start();
                    await _hubProxy.Invoke(SignalRKeys.FBSelfbot.ScheduleEnqueqed, jobId, response);
                    _connection.Stop();

                    if (!sr.Success) {
                        var msjService = new MerSchedJobService();
                        msjService.UpdateResult(jobId, sr);
                    }
                }

            }
            catch (Exception ex)
            {
                // 停止計時
                sw.Stop();
                LogService.AddLog(ex);
                sr.SetResult(ex);
            }
            finally {
               
                EmitExecutedJob(ScheduleName.FBAsyncOrder, reqStr, null);
            }
            return sr;
        }

        /// <summary>
        /// 更新貼文
        /// </summary>
        /// <param name="reqStr"></param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public async Task<ServiceResult<object>> UpdatePost(string reqStr, string jobId)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                var req = JsonConvert.DeserializeObject(reqStr);
                var reqObj = JObject.FromObject(req);
                using (var sbHttp = new MyHttpService(host))
                {

                    sw.Start();
                    reqObj.Add("JobId", jobId);
                    LogService.WriteJsonLog("UpdateWithFBPost", new { type = "START_REQUEST", reqObj });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("gsc/UpdateWithFBPost", reqObj);
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("UpdateWithFBPost", new { type = "END_REQUEST", reqObj, response, executedTime = elapsedTime });

                    if (!sr.Success)
                    {
                        var msjService = new MerSchedJobService();
                        msjService.UpdateResult(jobId, sr);
                    }
                }

            }
            catch (Exception ex)
            {
                // 停止計時
                sw.Stop();
                LogService.AddLog(ex);
                sr.SetResult(ex);
            }
            finally
            {
                EmitExecutedJob(ScheduleName.UpdateFBPost, reqStr, null);
            }
            return sr;
        }


        /// <summary>
        /// 刪除貼文
        /// </summary>
        /// <param name="reqStr"></param>
        /// <param name="jobId"></param>
        /// <returns></returns>
        public async Task<ServiceResult<object>> DeletePost(string reqStr, string jobId)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                var req = JsonConvert.DeserializeObject(reqStr);
                var reqObj = JObject.FromObject(req);
                using (var sbHttp = new MyHttpService(host))
                {

                    sw.Start();
                    reqObj.Add("JobId", jobId);
                    LogService.WriteJsonLog("DeleteWithFBPost", new { type = "START_REQUEST", reqObj });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("gsc/DeleteWithFBPost", reqObj);
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("DeleteWithFBPost", new { type = "END_REQUEST", reqObj, response, executedTime = elapsedTime });

                    if (!sr.Success)
                    {
                        var msjService = new MerSchedJobService();
                        msjService.UpdateResult(jobId, sr);
                    }
                }

            }
            catch (Exception ex)
            {
                // 停止計時
                sw.Stop();
                LogService.AddLog(ex);
                sr.SetResult(ex);
            }
            finally
            {
                EmitExecutedJob(ScheduleName.DeleteFBPost, reqStr, null);
            }
            return sr;
        }
    }
}
