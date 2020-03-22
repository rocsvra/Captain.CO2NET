using RestSharp;
using System;
using System.Net;

namespace Captain.HttpClient
{
    /// <summary>
    /// RestResponse扩展
    /// </summary>
    static class Ext4RestResponse
    {
        public static string GetResponseContent(this IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(string.Format("HTTP请求失败，ResponseStatus：{0}", response.ResponseStatus));
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("HTTP请求异常，状态码：{0}；错误信息：{1}", response.StatusCode, response.ErrorMessage));
            }
            if (string.IsNullOrEmpty(response.Content))
            {
                throw new Exception("HTTP请求成功,返回数据为空");
            }
            return response.Content;
        }

        public static T GetResponseContent<T>(this IRestResponse<T> response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new Exception(string.Format("HTTP请求失败，ResponseStatus：{0}", response.ResponseStatus));
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(string.Format("HTTP请求异常，状态码：{0}；错误信息：{1}", response.StatusCode, response.ErrorMessage));
            }
            return response.Data;
        }
    }
}
