using GroupBuy.Schedule.Binders;
using GroupBuy.Schedule.Models.Entites;
using GroupBuy.Schedule.Models.Schedule;
using GroupBuy.Schedule.Services;
using Hangfire.Server;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GroupBuy.Schedule.Services
{
    public class Base
    {
        
        public readonly GroupBuyEntities db;
        public int _merchantId;
        public int _userId;

        public Base() {
            db = EFService.CreateEntities();
        }
        public Base(int merchantId, int userId) {
            _merchantId = merchantId;
            _userId = userId;
        }

        public static async void EmitAddedJob(ScheduleName scheduleName, string payload)
        {
            var url = AppSettingService.Get("MerBaseUri");
            // 這裡填寫你的 ASP.NET MVC 伺服器端的 SignalR URL
            var _connection = new HubConnection(Path.Combine(url, "signalr"));
            // 指定要連接的 Hub 名稱，假設伺服器端有一個 "ChatHub"
            var _hubProxy = _connection.CreateHubProxy(SignalRKeys.Hub.ScheduleHub);
            try
            {
                // 開始連接
                await _connection.Start();

                await _hubProxy.Invoke(SignalRKeys.MerUsr.EmitAddedJob, scheduleName.ToString(), payload);
            }
            catch (Exception ex)
            {
                LogService.AddLog(ex);
            }
            finally
            {
                _connection.Stop();
            }
        }
        public static async void EmitExecutingJob(ScheduleName scheduleName, string payload, PerformContext context)
        {
            var url = AppSettingService.Get("MerBaseUri");
            // 這裡填寫你的 ASP.NET MVC 伺服器端的 SignalR URL
            var _connection = new HubConnection(Path.Combine(url, "signalr"));
            // 指定要連接的 Hub 名稱，假設伺服器端有一個 "ChatHub"
            var _hubProxy = _connection.CreateHubProxy(SignalRKeys.Hub.ScheduleHub);
            try
            {
                // 開始連接
                await _connection.Start();

                await _hubProxy.Invoke(SignalRKeys.MerUsr.EmitExecutingJob, scheduleName.ToString(), payload);
            }
            catch (Exception ex)
            {
                LogService.AddLog(ex);
            }
            finally
            {
                _connection.Stop();
            }
        }

        public static async void EmitExecutedJob(ScheduleName scheduleName, string payload, PerformContext? context)
        {
            var url = AppSettingService.Get("MerBaseUri");
            // 這裡填寫你的 ASP.NET MVC 伺服器端的 SignalR URL
            var _connection = new HubConnection(Path.Combine(url, "signalr"));
            // 指定要連接的 Hub 名稱，假設伺服器端有一個 "ChatHub"
            var _hubProxy = _connection.CreateHubProxy(SignalRKeys.Hub.ScheduleHub);
            try
            {
                // 開始連接
                await _connection.Start();

                await _hubProxy.Invoke(SignalRKeys.MerUsr.EmitExecutedJob, scheduleName.ToString(), payload);
            }
            catch (Exception ex)
            {
                LogService.AddLog(ex);
            }
            finally
            {
                _connection.Stop();
            }
        }
    }

}
