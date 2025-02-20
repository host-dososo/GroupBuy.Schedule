using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Services.Exceptions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace GroupBuy.Schedule.Models
{
    public class ServiceResult<T>
    {
        public bool Success { get { return Code > 0; } }

        public int Code { get; set; }

        public string _message { get; set; }

        public string Message { get {
                return _message;
            } set {
                LogService.WriteJsonLog("【ServiceResult】【Message】", value);
                _message = value;
            } }

        public string InnerMessage { get; set; }
        public T? Data { get; set; }


    }

    public static class ServiceResult 
    {
        public static ServiceResult<T> SetResult<T>(this ServiceResult<T> result, int code, string message)
        {
            result.Code = code;
            result.Message = message;
            return result;
        }
        public static ServiceResult<T> SetResult<T>(this ServiceResult<T> result, int code, T data)
        {
            result.Code = code;
            result.Data = data;
            return result;
        }
        public static ServiceResult<T> SetResult<T>(this ServiceResult<T> result, T data)
        {
            result.Code = 1;
            result.Data = data;
            return result;
        }
        public static ServiceResult<T> SetResult<T>(this ServiceResult<T> result, Exception ex)
        {
            result.Code = result.Code == 0 ? -999 : result.Code;
            result.Data = default(T);
            result.Message = result.Message ?? "此功能目前維護中，請稍後在操作此功能。";
            result.InnerMessage = ex.Message;
            return result;
        }
        public static void CheckToException<T>(this ServiceResult<T> result, bool condition,int code,string message,string? innerMessage = null)
        {
            try {
                if (condition) {
                    StackTrace stackTrace= new StackTrace();
                    StackFrame? frame = stackTrace.GetFrame(1);
                    var method = frame?.GetMethod();
                    if (!string.IsNullOrEmpty(innerMessage))
                    {
                        innerMessage = string.Concat(message, " ", innerMessage);
                    }
                    else {
                        innerMessage = message;
                    }
                    result.SetResult(code, message);
                    throw new ServiceException($"{message}", new Exception($"【{code}】- 【{method?.Name ?? ""}】/【{method?.DeclaringType?.Name ?? ""}】{innerMessage}"),code);
                }
            } catch (Exception ex)
            {
                LogService.WriteJsonLog("【ServiceResult】【CheckToException】", ex);
                throw;
            }
        }
    }
}
