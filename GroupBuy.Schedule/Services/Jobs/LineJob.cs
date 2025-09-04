
using GroupBuy.Schedule.Binders;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;
using Newtonsoft.Json.Linq;

namespace GroupBuy.Schedule.Services.Jobs
{
    public class LineJob
    {
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        public LineJob() {
            var url = AppSettingService.Get("MerBaseUri");
            // 這裡填寫你的 ASP.NET MVC 伺服器端的 SignalR URL
            _connection = new HubConnection(Path.Combine(url, "signalr"));
            // 指定要連接的 Hub 名稱，假設伺服器端有一個 "ChatHub"
            _hubProxy = _connection.CreateHubProxy(SignalRKeys.Hub.LineHub);
            
        }

        public async void CreatePost(string payload,string jobId)
        {
            try {
                // 開始連接
                await _connection.Start();
                JObject objPayload = JObject.Parse(payload);
                if (!string.IsNullOrEmpty(jobId)) { 
                    objPayload.Add("jobId", jobId);
                }

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
    }
}
