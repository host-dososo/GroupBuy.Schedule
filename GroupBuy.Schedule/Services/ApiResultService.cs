
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using static GroupBuy.Schedule.Services.ApiResult;
using System.Reflection;
using Action = GroupBuy.Schedule.Services.ApiResult.Action;

using Newtonsoft.Json;
using System.Web;
using static GroupBuy.Schedule.Services.ApiResult;
using Microsoft.Extensions.Logging;
using GroupBuy.Schedule.Models;
using System.Diagnostics;
using GroupBuy.Schedule.Services.Exceptions;
using Swashbuckle.AspNetCore.Annotations;

namespace GroupBuy.Schedule.Services
{
    public class ApiResultService
    {
        
    }
    [SwaggerSchema("test")]
    public class ApiResult<T>
    {
        public ApiResult() { }
        public ApiResult(string actionStr)
        {
            _actionExt = actionStr;
        }
        
        public ApiResult(Action action)
        {
            _action = action;
        }

        public ApiResult(byte? userId)
        {
            _userId = userId;
        }

        /// <summary>
        /// API 商業邏輯是否執行成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 內部程序紀錄 Code
        /// </summary>
        private string _code = "";

        /// <summary>
        /// 服務層傳出狀態瑪
        /// </summary>
        public int ServiceCode { get; set; }

        /// <summary>
        /// 其他錯誤原因
        /// </summary>
        public string OtherErrRea = null;

        /// <summary>
        /// 錯誤原因中替代的屬性
        /// </summary>
        [JsonIgnore] // 使用 [JsonIgnore] 属性排除 ErrReaParam 字段

        public object ErrReaParam = new
        {
            Column = "欄位",
            Data = "資料"
        };

        /// <summary>
        /// 內部程序紀錄 Action
        /// </summary>
        [JsonIgnore] // 使用 [JsonIgnore] 属性排除 _action 字段
        public readonly Action _action = Action.列表讀取;  // def

        /// <summary>
        /// 當下操作使用者
        /// </summary>
        [JsonIgnore] // 使用 [JsonIgnore] 属性排除 _userId 字段
        public int? _userId = null;

        /// <summary>
        /// 內部程序紀錄 Action
        /// </summary>
        [JsonIgnore] // 使用 [JsonIgnore] 属性排除 _action 字段
        public string _actionExt { get; set; }  

        /// <summary>
        /// API 輸出結果代碼
        /// </summary>
        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                string action = GetEnumCode(_action);
                bool isExtAction = !string.IsNullOrEmpty(_actionExt);
                if (isExtAction) {
                    action = _actionExt;
                }
                bool validAction = isExtAction || GetEnumValues<Action>().Contains(action);
                if (value != null && validAction && GetEnumValues<Status>().Contains(value.Substring(2, 2)))
                {
                    Type actionType = typeof(Action);
                    Type statusType = typeof(Status);
                    Type errReaType = typeof(ErrRea);
                    string typeCodeStr = value.Substring(0, 2);
                    string staCodeStr = value.Substring(2, 2);

                    string typeName = null;
                    if (isExtAction)
                    {
                        typeName = action;
                    }
                    else { 
                        typeName = Enum.GetName(actionType, Int32.Parse(typeCodeStr));
                    }
                    string staName = Enum.GetName(statusType, Int32.Parse(staCodeStr));
                    
                    string reaName = null;
                    using (UtilityService us = new UtilityService())
                    {
                        if (OtherErrRea != null)
                        {
                            reaName = "，" + OtherErrRea;
                        }
                        else if (value.Length > 4)
                        {
                            string errReaName = Enum.GetName(errReaType, Int32.Parse(value.Substring(4, 2)));
                            string errReaChi = us.GetSummaryByProp<ErrRea>(errReaName);
                            if (ErrReaParam != null)
                            {
                                errReaChi = GetErrReaWithParam(errReaChi, ErrReaParam);
                            }
                            reaName = "，" + errReaChi;
                        }
                    }

                    Message = staName + typeName + reaName;

                    if (Int32.Parse(staCodeStr) == 0)
                    {
                        Success = true;
                    }
                    else
                    {
                        Success = false;
                    }
                }
            }
        }

        public string Message { get; set; }
        public string InnerMessage { get; set; }

        public T Data { get; set; } = default(T);

    }

    public class ApiResult
    {

        public enum ErrRea
        {
            /// <summary>
            /// 此資料已被刪除。
            /// </summary>
            Deleted = 00,
            /// <summary>
            /// 此資料不存在。
            /// </summary>
            NotFound = 01,
            /// <summary>
            /// 未提供所需參數。
            /// </summary>
            NeedVariable = 02,
            /// <summary>
            /// 已有相同名稱。
            /// </summary>
            HasSameName = 03,
            /// <summary>
            /// 已有相同帳號。
            /// </summary>
            HasSameAcc = 04,
            /// <summary>
            /// {{COLUMN}}無法變更。
            /// </summary>
            ColumnNotUpdate = 05,
            /// <summary>
            /// 已有相同{{DATA}}。
            /// </summary>
            HasSameData = 10,
            /// <summary>
            /// 請輸入帳號與密碼。
            /// </summary>
            LoginNoAccOrPwd = 40,
            /// <summary>
            /// 帳號密碼錯誤，請檢查帳號與密碼。
            /// </summary>
            LoginErrAccOrPwd = 41,
            /// <summary>
            /// 查無此使用者。
            /// </summary>
            LoginNoUser = 42,
            /// <summary>
            /// 無權限使用任何頁面。
            /// </summary>
            LoginNoAuthAnyPage = 43,
            /// <summary>
            /// 此資料不存在或已被刪除。
            /// </summary>
            DeletedOrNotFound = 21,
            /// <summary>
            /// 傳入參數不符合格式。
            /// </summary>
            InputParamError = 98,
            /// <summary>
            /// 資料處理時發生錯誤。
            /// </summary>
            DataHandleError = 99,
        }

        public enum Action
        {
            列表讀取 = 00,
            單筆資料讀取 = 01,
            判斷 = 02,
            新增 = 10,
            編輯 = 20,
            刪除 = 30,
            登入 = 40,
            登出 = 41,
            匯出PDF = 50,
            系統執行 = 90,
            Log寫入 = 91,
            核銷 = 92,
        }

        public enum Status
        {
            順利執行 = 00,
            無法 = 01
        }

        public static string GetCode(Action action, Status status)
        {
            return GetEnumCode(action) + GetEnumCode(status);
        }

        public static List<string> GetEnumValues<T>()
        {
            Type enumType = typeof(T);
            List<string> result = new List<string>();
            Dictionary<Type, int> dict = new Dictionary<Type, int>() {
                { typeof(Action), 2},
                { typeof(Status), 2},
                { typeof(ErrRea), 2},
            };

            result = dict.Where(d => enumType == d.Key).Select(d =>
            {
                return Enum.GetValues(d.Key).Cast<T>().Select(e => ((int)((object)e)).ToString().PadLeft(2, '0')).ToList();
            }).FirstOrDefault();


            return result;
        }

        public static string GetEnumCode(Enum enumType)
        {
            string code = null;
            if (enumType is Action)
            {
                code = ((int)((Action)enumType)).ToString("D").PadLeft(2, '0');
            }
            else if (enumType is Status)
            {
                code = ((int)((Status)enumType)).ToString("D").PadLeft(2, '0');
            }
            else if (enumType is ErrRea)
            {
                code = ((int)((ErrRea)enumType)).ToString("D").PadLeft(2, '0');
            }

            return code;
        }

        public static string GetCode(Action action, Status status, ErrRea errRea)
        {
            return GetEnumCode(action) + GetEnumCode(status) + GetEnumCode(errRea);
        }

        public static string GetErrReaWithParam(string errRea, object param)
        {
            var paramProperties = param.GetType().GetProperties();
            foreach (var prop in paramProperties)
            {
                var key = prop.Name;
                var value = prop.GetValue(param).ToString();
                var replaceText = string.Concat("{{", key.ToUpper(), "}}");
                if (errRea != null && errRea.ToUpper().Contains(replaceText))
                {
                    errRea = errRea.Replace(replaceText, value);
                }
            }

            return errRea;
        }
    }

    public static class ApiResultExtension
    {
        
        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Exception ex, params object[] args)
        {
            Action action = result._action;
            // 查看有沒有符合客製化錯誤訊息
            var customErrMsg = CustomApiErrorMsg.GetErrSummaryFromException(ex);
            if (!string.IsNullOrWhiteSpace(customErrMsg))
            {
                result.OtherErrRea = customErrMsg;
            }
            if (ex is ServiceException)
            {
                result.OtherErrRea = result.OtherErrRea ?? ex.Message;
                result.ServiceCode = ((ServiceException)ex).Code;
            }
            result.InnerMessage = ex.Message;
            result.Code = GetCode(action, Status.無法, ErrRea.DataHandleError);
            
            LogService.AddLog(ex);
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, ErrRea errRea, object param = null)
        {
            Action action = result._action;
            result.ErrReaParam = param ?? result.ErrReaParam;
            result.Code = GetCode(action, status, errRea);
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, T data, ErrRea errRea, object param = null)
        {
            Action action = result._action;
            result.ErrReaParam = param ?? result.ErrReaParam;
            result.Data = data;
            result.Code = GetCode(action, status, errRea);
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, ErrRea errRea, ModelStateDictionary modelState)
        {
            Action action = result._action;
            result.Code = GetCode(action, status, errRea);
            result.InnerMessage = string.Join("\n", UtilityService.GetModelStateErrorMsg(modelState));
            return result;
        }
        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, T data, ErrRea errRea, ModelStateDictionary modelState)
        {
            Action action = result._action;
            result.Data = data;
            result.Code = GetCode(action, status, errRea);
            result.InnerMessage = string.Join("\n", UtilityService.GetModelStateErrorMsg(modelState));
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, T data, ModelStateDictionary modelState)
        {
            Action action = result._action;
            result.Data = data;
            result.OtherErrRea = string.Join("\n", UtilityService.GetModelStateErrorMsg(modelState, false));
            result.Code = GetCode(action, status, ErrRea.DataHandleError);
            result.InnerMessage = string.Join("\n", UtilityService.GetModelStateErrorMsg(modelState));
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, ErrRea errRea, object param = null)
        {
            Action action = result._action;
            result.ErrReaParam = param ?? result.ErrReaParam;
            result.Code = GetCode(action, Status.無法, errRea);
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status)
        {
            Action action = result._action;
            result.Code = GetCode(action, status);
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, T data)
        {
            Action action = result._action;
            result.Code = GetCode(action, Status.順利執行);
            result.Data = data;
            return result;
        }
        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, ServiceResult<T> serviceResult)
        {
            Action action = result._action;
            result.OtherErrRea = serviceResult.Message;
            result.Code = GetCode(action, serviceResult.Success ? Status.順利執行 : Status.無法);
            result.Data = serviceResult.Data;
            result.ServiceCode = serviceResult.Code;
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, T data, string message)
        {
            Action action = result._action;
            result.Code = GetCode(action, Status.順利執行);
            result.Data = data;
            result.Message = message;
            return result;
        }

        public static ApiResult<T> SetResult<T>(this ApiResult<T> result, Status status, T data)
        {
            Action action = result._action;
            result.Code = GetCode(action, status);
            result.Data = data;
            return result;
        }

        public static ApiResult<T> SetUser<T>(this ApiResult<T> result, int? userId)
        {
            result._userId = userId;

            return result;
        }

        public static ApiResult<T> Add<T>(this ApiResult<object> result, Action action)
        {
            ApiResult<T> newResult = new ApiResult<T>(action);
            return newResult;
        }

        public static ApiResult<object> Init(this ApiResult<object> result, int? userId)
        {
            result.SetUser(userId);
            return result;
        }

        public static ApiResult<T> SetData<T>(this ApiResult<T> result, T data)
        {
            result.Data = data;
            return result;
        }

        public static ApiResult<T> SetData<T>(this ApiResult<dynamic> result, T data)
        {
            ApiResult<T> newResult = new ApiResult<T>(result._action);
            newResult.Code = result.Code;
            newResult.SetData<T>(data);

            return newResult;
        }

        public static ApiResult<T> SetErrRea<T>(this ApiResult<T> result, string errRea)
        {
            Action action = result._action;
            result.OtherErrRea = errRea;
            result.Code = GetCode(action, Status.無法);
            return result;
        }

        public static JsonResult ToJson<T>(this ApiResult<T> result)
        {
            //var json = new JsonResult(result);
            //json()
            JsonResult jsonResult = new JsonResult(result);
            return jsonResult;
        }

        public static void CheckToException<T>(this ApiResult<T> result, bool condition, string message)
        {
            try
            {
                if (condition)
                {
                    StackTrace stackTrace = new StackTrace();
                    StackFrame? frame = stackTrace.GetFrame(1);
                    var method = frame?.GetMethod();

                    result.SetErrRea(message);
                    throw new Exception($"【{method?.Name ?? ""}】/【{method?.DeclaringType?.Name ?? ""}】{message}");
                }
            }
            catch (Exception ex)
            {
                LogService.WriteJsonLog("【ApiResult】【CheckToException】",ex);
                throw ex.GetBaseException();
            }
        }
    }

    /// <summary>
    /// 客製化 API 錯誤內容 (依專案調整)
    /// </summary>
    public static class CustomApiErrorMsg
    {
        public enum SQL
        {
            /// <summary>
            /// 已有相同訂位傳票編號
            /// </summary>
            CK_SeatPayRecord_AppCerLastNum,
        }

        public readonly static Dictionary<Type, Type> ExceptionErrorToEnum = new Dictionary<Type, Type>() {
            //{ typeof(System.Data.SqlClient.SqlException),typeof(SQL)}
        };

        /// <summary>
        /// 取得客製化錯誤內容 (放 Summary)
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string GetErrSummaryFromException(Exception ex)
        {
            string result = null;
            // 取得該 Exception 對應 Enum
            var errorEnumDict = ExceptionErrorToEnum.FirstOrDefault(d => d.Key == ex.GetType());
            if (errorEnumDict.Key != null && errorEnumDict.Value != null)
            {
                var errorEnumType = errorEnumDict.Value;
                if (errorEnumType.IsEnum)
                {
                    // 取得該 Enum 所有 Name
                    List<string> enumNames = Enum.GetNames(errorEnumType).ToList();
                    // 取得單筆錯誤文字中有包含某個Name
                    string enumName = enumNames.FirstOrDefault(en => (ex.Message ?? "").Contains(en));
                    if (string.IsNullOrWhiteSpace(enumName))
                    {
                        return null;
                    }
                    using (UtilityService us = new UtilityService())
                    {
                        // 取得 summary
                        MethodInfo method = typeof(UtilityService).GetMethod("GetEnumSummary");
                        MethodInfo genericMethod = method.MakeGenericMethod(errorEnumType);
                        string summary = genericMethod.Invoke(us, new object[] { enumName })?.ToString();
                        result = summary;
                    }
                }
            }

            return result;
        }
    }
}
