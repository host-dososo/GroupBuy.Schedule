
using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models.Schedule;
using GroupBuy.Schedule.Models;
using GroupBuy.Schedule.Services.Repos;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;
using GroupBuy.Schedule.Models.Entites;

namespace GroupBuy.Schedule.Services.Jobs
{
    public class LineJob : Base
    {
        private readonly IHubProxy _hubProxy;
        private readonly HubConnection _connection;
        private readonly string host = AppSettingService.Get("MerBaseUri");

        public LineJob() : this(0, 0)
        {
            (_connection, _hubProxy) = InitConnection(0, 0);
        }

        public LineJob(int merchantId, int userId) : base(merchantId, userId)
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
            var hubProxy = connection.CreateHubProxy(SignalRKeys.Hub.LineHub);
            return (connection, hubProxy);
        }

        public async void CreatePost(string payload,string jobId)
        {
            try {
                // 開始連接
                JObject objPayload = JObject.Parse(payload);
                if (!string.IsNullOrEmpty(jobId)) { 
                    objPayload.Add("jobId", jobId);
                }

                await _connection.Start();
                if (_connection.State == ConnectionState.Connected)
                {
                    await _hubProxy.Invoke(SignalRKeys.MerUsr.CreatePost, objPayload);
                }
                else
                {
                    // 可選擇先等待連線恢復
                    await _connection.Start();
                    await _hubProxy.Invoke(SignalRKeys.MerUsr.CreatePost, objPayload);
                }
                
            }
            catch (Exception ex) {
                LogService.AddLog(ex);
            }
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
                    LogService.WriteJsonLog("UpdateWithLinePost", new { type = "START_REQUEST", reqObj });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("gsc/UpdateWithLinePost", reqObj);
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("UpdateWithLinePost", new { type = "END_REQUEST", reqObj, response, executedTime = elapsedTime });

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
                EmitExecutedJob(ScheduleName.UpdateLinePost, reqStr, null);
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
                    LogService.WriteJsonLog("DeleteWithLinePost", new { type = "START_REQUEST", reqObj });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("gsc/DeleteWithLinePost", reqObj);
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("DeleteWithLinePost", new { type = "END_REQUEST", reqObj, response, executedTime = elapsedTime });

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
                EmitExecutedJob(ScheduleName.DeleteLinePost, reqStr, null);
            }
            return sr;
        }
    }
}
