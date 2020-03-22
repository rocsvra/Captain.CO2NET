using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Captain.HttpClient
{
    /// <summary>
    /// 执行Post请求
    /// </summary>
    public class HttpsPost
    {
        /// <summary>
        /// 方法：post
        /// 结果：T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <param name="body">参数体</param>
        /// <param name="contentType"></param>
        /// <param name="certs">证书</param>
        /// <param name="encoding">通讯数据字符串编码</param>
        /// <returns></returns>
        public static T Execute<T>(string baseUrl, string resource, object body, string contentType, List<X509Certificate> certs, Encoding encoding = null) where T : new()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, errors) => true;

            var client = new RestClient(baseUrl);
            client.ClientCertificates = new X509CertificateCollection(certs.ToArray());
            client.Encoding = encoding ?? Encoding.UTF8;

            var request = new RestRequest(resource, Method.POST);
            if (string.IsNullOrEmpty(contentType))
            {
                request.AddHeader("content-type", contentType);
            }
            if (body != null)
            {
                request.AddObject(body);
            }
            var response = client.Execute<T>(request);
            return response.Data;
        }
    }
}
