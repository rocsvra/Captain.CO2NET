using RestSharp;

namespace Captain.HttpClient
{
    /// <summary>
    /// HttpGet请求
    /// </summary>
    public class HttpGet
    {        
        /// <summary>
        /// 执行Get请求
        /// </summary>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <returns></returns>
        public static string Execute(string baseUrl, string resource = "")
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var response = client.Execute(request);
            return response.GetResponseContent();
        }

        /// <summary>
        /// 执行Get请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseUrl"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static T Execute<T>(string baseUrl, string resource = "")
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var response = client.Execute<T>(request);
            return response.Data;
        }
    }
}
