
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data.Common;
using Newtonsoft.Json;
using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Models.Entites;
using Microsoft.Extensions.Configuration.UserSecrets;


namespace GroupBuy.Schedule.Services
{
    public class DBLogService : Base
    {
        public int? _userId = null;
        public static readonly Dictionary<short, List<Type>> exceptionLevels = new Dictionary<short, List<Type>>() {
            { 1, new List<Type> { typeof(System.Exception) } },
            { 2, new List<Type> {
                typeof(System.StackOverflowException),
                typeof(System.OutOfMemoryException),
                typeof(System.Threading.ThreadAbortException),
                typeof(System.ExecutionEngineException),
                typeof(System.AccessViolationException),
                typeof(System.AppDomainUnloadedException),
                typeof(System.TypeInitializationException)
            } },
            { 3, new List<Type> {
                typeof(System.Data.SqlTypes.SqlNullValueException),
                typeof(System.Data.SqlTypes.SqlTruncateException),
                typeof(System.OverflowException),
                typeof(System.InvalidCastException),
                typeof(System.FormatException),
                typeof(System.ArgumentException),
                typeof(System.NullReferenceException),
                typeof(System.IndexOutOfRangeException),
                typeof(System.DivideByZeroException),
                typeof(System.IO.IOException),
                typeof(System.Security.SecurityException),
                typeof(System.Net.WebException),
            } },
            { 4, new List<Type> {
                typeof(System.Data.DataException) // 新增 DataException
            } },
            { 5, new List<Type> {

            } },
            { 6, new List<Type> {  } }, // 新增 DbEntityValidationException
            // 可以根據需要繼續添加其他 Exception 類型和對應的錯誤級別
        };

        public DBLogService(int? userId = null)
        {
            _userId = userId;
        }


        /// <summary>
        /// 寫入 DB ErrorLog
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int InsertDbLog(ErrorLog input)
        {
            try
            {

                input.UserId = _userId;

                db.ErrorLog.Add(input);
                db.SaveChanges();
                if (input.Id == null)
                {
                    return -1;
                }

                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ErrorLog SetErrorLog(Exception ex, string errCode, params object[] args)
        {
            int? severity = exceptionLevels.Where(l => l.Value.Contains(ex.GetType())).Select(l => l.Key).FirstOrDefault();
            // 獲取異常的堆棧跟踪信息
            StackTrace stackTrace = new StackTrace(ex);
            // 獲取異常的頂級堆棧幀
            StackFrame stackFrame = stackTrace.GetFrame(0);
            // 取得錯誤代號
            string errorType = errCode ?? ex.GetType().Name;
            return SetErrorLog(stackFrame, severity, ex.ToString(), errCode, args);
        }

        /// <summary>
        /// 根據 Exception 設置 Error Log 物件並取得
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="errCode"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public ErrorLog SetErrorLog(StackFrame stackFrame, int? severity, string message, string errCode, params object[] args)
        {


            // 獲取引發異常的方法的名稱
            string methodName = stackFrame.GetMethod().Name;

            // 獲取引發異常的代碼的行號
            int lineNumber = stackFrame.GetFileLineNumber();

            string paramsValue = string.Join("#^", args.Select(a => JsonConvert.SerializeObject(a)));

            ErrorLog result = new ErrorLog()
            {
                Date = DateOnly.FromDateTime(DateTime.Today),
                Time = TimeOnly.FromDateTime(DateTime.Now),
                Severity = (severity ?? 0).ToString(),
                Number = errCode ?? "0",
                Source = methodName,
                Line = lineNumber.ToString(),
                Message = message,
                State = null,
                From = 1,
                ParamValues = paramsValue,
                SolveDate = null,
                SolveStatus = null,
                UserId = _userId,
                UserType = (byte?)0
            };

            return result;

        }

        /// <summary>
        /// 紀錄 Log
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="errCode"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public int AddLog(Exception ex, string errCode = null, params object[] args)
        {
            var result = new ErrorLog();
            result = SetErrorLog(ex, errCode, args);
            return InsertDbLog(result);
        }

        /// <summary>
        /// 是否為 source map request 錯誤 
        /// </summary>
        /// <returns></returns>
        public bool IsSourceMapAppError(string errorMsg)
        {
            Regex regex = new Regex(".*找不到路徑.*\\/?\\.map\\'");
            if (string.IsNullOrEmpty(errorMsg))
            {
                return false;
            }
            return regex.IsMatch(errorMsg);
        }
    }



}
