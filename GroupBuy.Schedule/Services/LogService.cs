using GroupBuy.Schedule.Models.Entites;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using static GroupBuy.Schedule.Services.LogService;

namespace GroupBuy.Schedule.Services
{
    public static partial class LogService
    {
        public static ILogger logger;
        public static int? _userId { get; set; }
        

        public static void Configure(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger("LogService");
        }
        public static void AddLog(Exception ex, string logname = "ErrorLog")
        {
            try
            {
                DBLogService dbLogService = new DBLogService();
               // dbLogService.AddLog(ex);
                WriteJsonLog(logname, ex.ToString());
            }
            catch (Exception e)
            {
                WriteJsonLog(logname, e.ToString());
            }
        }
        public static void WriteJsonLog(string logName, object data)
        {
            // 獲取當前日期
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            string logDirectory = Path.Combine(EnvService.ContentRootPath, "Log");

            string logFilePath = Path.Combine(logDirectory, $"{currentDate}.json");

            // 確保 logs 資料夾存在
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            // 獲取堆疊框架信息
            StackTrace stackTrace = new StackTrace();
            StackFrame frame = stackTrace.GetFrame(1); // 獲取呼叫這個方法的上一層方法
            var method = frame.GetMethod();
            string className = method.DeclaringType.Name;
            string methodName = method.Name;
            int lineNumber = frame.GetFileLineNumber();

            // 創建日誌結構
            var logEntry = new
            {
                log_name = logName,
                write_time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                class_name = className,
                method_name = methodName,
                line_number = lineNumber,
                data
            };
            JArray logArray;

            // 如果檔案存在，讀取現有日誌，並追加新的記錄
            if (System.IO.File.Exists(logFilePath))
            {
                string existingLogs = System.IO.File.ReadAllText(logFilePath);
                logArray = JArray.Parse(existingLogs);
            }
            else
            {
                logArray = new JArray();
            }

            logArray.Add(JObject.FromObject(logEntry));
            // 將日誌寫入檔案
            System.IO.File.WriteAllText(logFilePath, logArray.ToString(Formatting.None));
        }
    }
}
