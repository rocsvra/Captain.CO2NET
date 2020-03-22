using RestSharp;

namespace Captain.HttpClient
{
    /// <summary>
    /// HttpPost请求
    /// </summary>
    public class HttpPost
    {
        /// <summary>
        /// 执行Post请求
        /// </summary>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <param name="body">body参数体</param>
        /// <returns></returns>
        public static string Execute(string baseUrl, string resource = "", object body = null)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.AddJsonBody(body);

            var response = client.Execute(request);
            return response.GetResponseContent();
        }

        /// <summary>
        /// 执行Post请求
        /// </summary>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <param name="body">body参数体</param>
        /// <returns></returns>
        public static T Execute<T>(string baseUrl, string resource = "", object body = null)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.AddJsonBody(body);

            var response = client.Execute<T>(request);
            return response.GetResponseContent<T>();
        }
    }
}
