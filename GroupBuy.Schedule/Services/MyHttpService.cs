using GroupBuy.Schedule.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace GroupBuy.Schedule.Services
{
    public class MyHttpService : IDisposable
    {
        private string host;
        private readonly HttpClient _httpClient;
        public TimeSpan Timeout = TimeSpan.FromSeconds(30);

        public MyHttpService(string _host)
        {
            host = _host;
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            _httpClient = new HttpClient(handler);
            _httpClient.Timeout = TimeSpan.FromSeconds(60);
            _httpClient.BaseAddress = new Uri(host);
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public string GetFullUrl(string parturl, object query = null)
        {
            try
            {
                string url = Path.Combine("api/", parturl);
                if (query != null)
                {
                    var properties = from p in query.GetType().GetProperties()
                                     where p.GetValue(query, null) != null
                                     select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(query, null).ToString());
                    var querystring = string.Join("&", properties.ToArray());
                    url = $"{url}?{querystring}";
                }
                return url;
            }
            catch (Exception ex)
            {
                return host;
            }
        }

        public class IgnoreCaseContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                if (propertyName.ToLower() == "okflag") {
                    return "success";
                }
                return propertyName.ToLower();
            }
        }

        public T ToApiResult<T>(JObject response) where T: new() {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new IgnoreCaseContractResolver()
            };
            T model = response.ToObject<T>(JsonSerializer.Create(settings));
            var props = model.GetType().GetProperties();
            foreach (var prop in props) {
                if (prop.PropertyType == typeof(object)) { 
                    var value = prop.GetValue(model, null);
                }
            }
            return model;
        }

        public async Task<T> GetAsync<T>(string parturl, object query = null) where T: new() 
        {
            // 建立 CancellationTokenSource 並設定 30 秒的超時
            using (CancellationTokenSource cts = new CancellationTokenSource(Timeout))
            {
                try
                {

                    var response = await _httpClient.GetAsync(GetFullUrl(parturl, query),cts.Token).ConfigureAwait(false);
                    response.EnsureSuccessStatusCode();
                    var jsonResponse = await response.Content.ReadAsStringAsync();

                    var jobject = JObject.Parse(jsonResponse);

                    var result = ToApiResult<T>(jobject);
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async Task<T> PostAsync<T>(string parturl, object data) where T : new()
        {
            // 建立 CancellationTokenSource 並設定 30 秒的超時
            using (CancellationTokenSource cts = new CancellationTokenSource(Timeout))
            {
                try
                {
                    var jsonData = JsonConvert.SerializeObject(data);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(jsonData);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    //var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await _httpClient.PostAsync(GetFullUrl(parturl), byteContent, cts.Token).ConfigureAwait(false);
                    var responseContent = await GetResponseContent(response);
                    response.EnsureSuccessStatusCode();
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var jobject = JObject.Parse(jsonResponse);

                    var result = ToApiResult<T>(jobject);
                    return result;
                }
                catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public async Task<T> PutAsync<T>(string parturl, string data)
        {
            // 建立 CancellationTokenSource 並設定 30 秒的超時
            using (CancellationTokenSource cts = new CancellationTokenSource(Timeout))
            {
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(GetFullUrl(parturl), content, cts.Token);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
        }

        public async Task<T> DeleteAsync<T>(string parturl)
        {
            // 建立 CancellationTokenSource 並設定 30 秒的超時
            using (CancellationTokenSource cts = new CancellationTokenSource(Timeout))
            {
                var response = await _httpClient.DeleteAsync(GetFullUrl(parturl), cts.Token);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
        }

        public async Task<JObject> GetResponseContent(HttpResponseMessage response) {
            try {
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    var serializer = new JsonSerializer();
                    using (var sr = new StreamReader(stream))
                    using (var reader = new StreamReader(stream))
                    {
                        var strContent = await reader.ReadToEndAsync();
                        JObject result = JObject.Parse(strContent);
                        return result;
                    }

                }
            }
            catch {
                return null;
            }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
