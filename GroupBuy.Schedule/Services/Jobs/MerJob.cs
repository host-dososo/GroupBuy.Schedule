
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
    public class MerJob
    {
        private string host = AppSettingService.Get("MerBaseUri");
        public MerJob() {
            
        }

        public async Task<ServiceResult<object>> SupGooToMer(string reqStr, string jobId)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                var req = JObject.Parse(reqStr);
                var obj = req.ToObject<object>();
                using (var sbHttp = new MyHttpService(host))
                {
                    sw.Start();
                    LogService.WriteJsonLog("SupGooToMer", new { type = "START_REQUEST", req = req.ToObject<object>() });
                    var response = await sbHttp.PostAsync<ApiResult<object>>("merchant/SupGooToMer", new {
                        merchantId = req.Value<int?>("merchantId"),
                        salesStatus = req.Value<string>("salesStatus"),
                        preOrder = req.Value<string>("preOrder"),
                        jobId = jobId,
                    });
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    //sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("SupGooToMer", new { type = "END_REQUEST", req, response, executedTime = elapsedTime });
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

        public async Task<ServiceResult<object>> ValidWriteUID(string reqStr)
        {
            Stopwatch sw = new Stopwatch();
            ServiceResult<object> sr = new ServiceResult<object>();
            try
            {
                var req = JsonConvert.DeserializeObject(reqStr);
                var reqObj = JObject.FromObject(req);
                var merchantId = reqObj.Value<int?>("merchantId");
                var authHashCode = reqObj.Value<string>("authHashCode");
                using (var sbHttp = new MyHttpService(host))
                {
                    sw.Start();
                    LogService.WriteJsonLog("ValidWriteUID", new { type = "START_REQUEST", merchantId, authHashCode });
                    var response = await sbHttp.GetAsync<ApiResult<object>>("soc/fb/ValidWriteUID", new {
                        merchantId,
                        authHashCode
                    });
                    // 停止計時
                    sw.Stop();
                    // 獲取執行時間
                    TimeSpan ts = sw.Elapsed;
                    // 格式化輸出
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                    sr = DataService.MergeData<ServiceResult<object>>(response);
                    //sr.Code = response.ServiceCode;
                    LogService.WriteJsonLog("ValidWriteUID", new { type = "END_REQUEST", response, executedTime = elapsedTime });
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
