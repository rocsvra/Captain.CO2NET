using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;

namespace Captain.HttpClient
{
    /// <summary>
    /// Working with Files
    /// </summary>
    public class HttpFile
    {
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="savePath">存储路径</param>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        public static void Download(string savePath, string baseUrl, string resource = "")
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource);
            byte[] response = client.DownloadData(request);
            File.WriteAllBytes(savePath, response);
        }

        /// <summary>
        /// 下载文件(大文件)
        /// </summary>
        /// <param name="savePath">存储路径</param>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <returns></returns>
        public static void Download4LargeData(string savePath, string baseUrl, string resource = "")
        {
            using (var writer = File.OpenWrite(Path.GetTempFileName()))
            {
                var client = new RestClient(baseUrl);
                var request = new RestRequest(resource);
                request.ResponseWriter = responseStream =>
                {
                    using (responseStream)
                    {
                        responseStream.CopyTo(writer);
                    }
                };
                var response = client.DownloadData(request);
                File.WriteAllBytes(savePath, response);
            }
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="files">文件键值对，值为文件路径</param>
        /// <param name="baseUrl">服务器地址</param>
        /// <param name="resource">资源定位</param>
        /// <returns></returns>
        public static string UploadFile(Dictionary<string, string> files, string baseUrl, string resource = "")
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource);

            foreach (var file in files)
            {
                if (File.Exists(file.Value))
                {
                    request.AddFile(file.Key, file.Value);
                }
                else
                {
                    throw new Exception(string.Format("文件不存在，文件路径：{0}", file.Value));
                }
            }
            var response = client.Execute(request);
            return response.GetResponseContent();
        }
    }
}
