using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace GroupBuy.Schedule.Services
{
    public static class UrlService
    {

        public static string Combine(params string[] parts)
        {
            if (parts == null || parts.Length == 0)
            {
                throw new ArgumentException("No URL parts provided");
            }

            // 去掉每個部分的開頭和結尾的 '/'
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == null) continue;
                parts[i] = parts[i].Trim('/');
            }

            // 使用 '/' 組合所有部分
            return string.Join("/", parts);
        }
        public static string SetQuery(this string url, IDictionary<string, object> queries)
        {
            if (queries != null)
            {
                var queryList = new List<string>();
                var queryRegex = new Regex("[?&]([^=#]+)=([^&#]*)");
                var queryMatches = queryRegex.Matches(url);
                if (queryMatches.Count > 0) {
                    var queryBackRegex = new Regex("\\?.*");
                    url = queryBackRegex.Replace(url, "");
                }
                foreach (Match match in queryMatches)
                {
                    var key = match.Groups[1].Value;
                    var value = match.Groups[2].Value;
                    if (queries.ContainsKey(key))
                    {
                        queries[key] = value;
                    }
                    else {
                        queries.Add(key, value);
                    }
                }
                foreach (var query in queries) {
                    if (string.IsNullOrEmpty(query.Key) || string.IsNullOrEmpty(query.Value.ToString())) continue;
                    var qs = query.Key + "=" + HttpUtility.UrlEncode(query.Value.ToString());
                    queryList.Add(qs);
                }

                var querystring = string.Join("&", queryList);
                url = url.Replace("?", "");
                url = $"{url}?{querystring}";
            }

            // 使用 '/' 組合所有部分
            return url;
        }

        public static string SetQuery(this string url, object queries)
        {
            if (queries != null)
            {
                IDictionary<string,object> obj = new ExpandoObject();
                foreach (var p in queries.GetType().GetProperties()) {
                    obj.Add(p.Name, HttpUtility.UrlEncode(p.GetValue(queries, null).ToString()));
                }
                url = url.SetQuery(obj);
            }

            // 使用 '/' 組合所有部分
            return url;
        }
    }
}
