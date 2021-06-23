using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AuthoritySystem.Common.Helper
{
    public class HttpClientHelper
    {
        public static async Task<string> GetAsync(string url, Dictionary<string, string> header = null)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient();
            // 构建一个容器
            var serviceProvider = serviceCollection.BuildServiceProvider();
            IHttpClientFactory httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

            using (var client = httpClientFactory.CreateClient())
            {
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }

        }

        /// <summary>
        /// 发送get异步请求直接返回对象
        /// </summary>
        /// <typeparam name="T">返回对象类型</typeparam>
        /// <param name="url">url地址</param>
        /// <param name="header">头部参数</param>
        /// <returns></returns>
        public static async Task<T> GetObjectAsync<T>(string url, Dictionary<string, string> header = null)
        {
            string responseBody = await GetAsync(url, header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }

        public static async Task<string> PostAsyncJson(string url, string json, Dictionary<string, string> header = null)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddHttpClient();
            // 构建一个容器
            var serviceProvider = serviceCollection.BuildServiceProvider();
            IHttpClientFactory httpClientFactory = serviceProvider.GetService<IHttpClientFactory>();

            using (var client = httpClientFactory.CreateClient())
            {
                HttpContent content = new StringContent(json);
                // 设置请求格式
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                // 添加头部信息
                if (header != null)
                {
                    client.DefaultRequestHeaders.Clear();
                    foreach (var item in header)
                    {
                        client.DefaultRequestHeaders.Add(item.Key, item.Value);
                    }
                }
                // 调用Post方法
                HttpResponseMessage response = await client.PostAsync(url, content);
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
        }

        public static async Task<T> PostObjectAsync<T, T2>(string url, T2 obj, Dictionary<string, string> header = null)
        {
            String json = JsonConvert.SerializeObject(obj);
            string responseBody = await PostAsyncJson(url, json, header);
            // 反序列化
            return JsonConvert.DeserializeObject<T>(responseBody);
        }
    }
}
