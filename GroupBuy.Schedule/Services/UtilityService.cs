using System.Text;
using GroupBuy.Schedule.Services;
using System.Reflection;
using System.Xml;
using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using HashidsNet;

namespace GroupBuy.Schedule.Services
{
    public class UtilityService : IDisposable
    {
        private readonly string xmlDocPath;
        public UtilityService()
        {
            // 獲取當前執行程序的程序集
            Assembly assembly = Assembly.GetExecutingAssembly();
            // 獲取程序集的名稱
            string projectName = assembly.GetName().Name;
            Console.WriteLine(AppContext.BaseDirectory);
            
            xmlDocPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{projectName}.xml");
        }

        void IDisposable.Dispose() { }
        //ByteToString
        public static string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("X2"); /* hex format */
            return sbinary.ToLower();
        }
        public static string GenHash(params long[] numbers)
        {
            //For more information on hashids, visit https://hashids.org/net/

            string connectionString = AppSettingService.GetConnectionString();
            string salt = AppSettingService.Get("HashSalt");
            var hashids = new Hashids(salt, 16);
            numbers = ProcessNumbersForEncoding(numbers);
            var hash = hashids.EncodeLong(numbers);
            return hash;
        }

        public static string GenHashByLen(int len, params long[] numbers)
        {
            //For more information on hashids, visit https://hashids.org/net/

            string connectionString = AppSettingService.GetConnectionString();
            string salt = AppSettingService.Get("HashSalt");
            numbers = ProcessNumbersForEncoding(numbers);
            var hashids = new Hashids(salt, len);
            var hash = hashids.EncodeLong(numbers);
            return hash;
        }
        public static long[] DecHash(string hash, int len = 16)
        {
            //For more information on hashids, visit https://hashids.org/net/
            string salt = AppSettingService.Get("HashSalt");
            var hashids = new Hashids(salt, len);
            var numArr = hashids.DecodeLong(hash);
            // 解碼後恢復負數
            long[] originalNumbers = RestoreNumbersAfterDecoding(numArr);
            return originalNumbers;
        }
        public static long[] DecHashByLen(int len, string hash)
        {
            //For more information on hashids, visit https://hashids.org/net/
            string salt = AppSettingService.Get("HashSalt");
            var hashids = new Hashids(salt, len);
            var numArr = hashids.DecodeLong(hash);
            // 解碼後恢復負數
            long[] originalNumbers = RestoreNumbersAfterDecoding(numArr);
            return originalNumbers;
        }
        // 將負數處理為正數，並添加標記
        static long[] ProcessNumbersForEncoding(long[] numbers)
        {
            long[] processed = new long[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    processed[i] = (-numbers[i] * 2) - 1;
                }
                else
                {
                    processed[i] = numbers[i] * 2;
                }
            }
            return processed;
        }

        // 將標記過的數字恢復為原始數字
        static long[] RestoreNumbersAfterDecoding(long[] numbers)
        {
            long[] restored = new long[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    restored[i] = numbers[i] / 2;
                }
                else
                {
                    restored[i] = -(numbers[i] + 1) / 2;
                }
            }
            return restored;
        }
        /// <summary>
        /// 獲取XML文檔註釋摘要
        /// </summary>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        public string GetSummary(MemberInfo memberInfo)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlDocPath);
                string fullName = (memberInfo?.DeclaringType?.FullName ?? "").Replace("+", ".");
                string xpath = $"/doc/members/member[contains(@name,'{fullName}.{memberInfo.Name}')]/summary";
                XmlNode summaryNode = xmlDoc.SelectSingleNode(xpath);

                return summaryNode?.InnerText.Trim() ?? "沒有找到註釋摘要。";
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }
        /// <summary>
        /// 抓取某個類別(T)的某個屬性(propName)的 XML 摘要
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propName"></param>
        /// <returns></returns>
        public string GetSummaryByProp<T>(string propName)
        {
            Type type = typeof(T);

            FieldInfo propInfo = type.GetField(propName);
            string propertySummary = GetSummary(propInfo);

            return propertySummary;
        }
        /// <summary>
        /// 抓取 Model Binding Validate State 錯誤訊息
        /// </summary>
        /// <param name="modelStates"></param>
        /// <returns></returns>
        public static List<string> GetModelStateErrorMsg(ModelStateDictionary modelStates, bool isException = true)
        {
            List<string> result = new List<string>();
            try
            {
                foreach (var key in modelStates.Keys)
                {
                    var entry = modelStates[key];

                    var errors = entry.Errors;
                    foreach (var error in errors)
                    {
                        if (isException)
                        {
                            result.Add(error?.Exception?.Message ?? "");
                        }
                        else
                        {
                            result.Add(error.ErrorMessage ?? "");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static string ConvertEmojiToUnicode(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsSurrogate(c))
                {
                    int codepoint = char.ConvertToUtf32(input, input.IndexOf(c));
                    sb.Append("\\u" + codepoint.ToString("X4"));
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        public static class String
        {
            public static bool IsUrl(string input)
            {
                return Uri.TryCreate(input, UriKind.Absolute, out Uri uriResult) && uriResult?.Scheme == Uri.UriSchemeHttp || uriResult?.Scheme == Uri.UriSchemeHttps;
            }

            public static bool IsBase64(string input)
            {
                try
                {
                    if (!(input ?? "").Contains(","))
                    {
                        return false;
                    }
                    input = input.Split(',')[1];
                    byte[] result = Convert.FromBase64String(input);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }
    }
}


public class JsonResultData
{
    public bool OKFlag { get; set; }  //是否成功
    public string StatusCode { get; set; }  //狀態代碼
    public string Message { get; set; }     //訊息
    public string Url { get; set; }          //跳轉網址
    public object Data { get; set; }         //回傳資料
    /// <summary>
    /// 
    /// </summary>
    /// <param name="oKFlag_">是否成功(預設)</param>
    /// <param name="statusCode_">狀態代碼(預設)</param>
    /// <param name="message_">訊息(預設)</param>
    public JsonResultData(bool oKFlag_ = true, string statusCode_ = "1", string message_ = "執行成功")
    {
        OKFlag = oKFlag_;
        StatusCode = statusCode_;
        Message = message_;
    }
}
