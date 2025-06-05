using Light.Lazada.Common;
using System;
using System.Collections.Generic;
using System.Web;

namespace Light.Lazada.Models
{
    public class LazadaApiCredential
    {
        public string AppKey { get; set; }

        public string AppSecret { get; set; }

        public string AccessToken { get; set; }

        public string BaseUrl { get; set; }

        public string GenerateQueryUrl(string path, Dictionary<string, string> request)
        {
            // base url
            var url = $"{BaseUrl}{path}";

            url += "?" + UrlQueryBuilder(path, request, false);

            return url;
        }

        public string GenerateAuthUrl(string path, Dictionary<string, string> request)
        {
            // base url
            var url = $"https://auth.lazada.com/rest{path}";

            url += "?" + UrlQueryBuilder(path, request, true);

            return url;
        }

        private string UrlQueryBuilder(string path, Dictionary<string, string> request, bool forAuth)
        {
            var appKey = AppKey;
            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var signMethod = Signature.SIGN_METHOD_SHA256;

            request.Add("app_key", appKey);
            request.Add("timestamp", timestamp.ToString());
            request.Add("sign_method", signMethod);

            // exclude AccessToken params when build url query for Auth
            if (forAuth is false)
            {
                var accessToken = AccessToken;
                request.Add("access_token", accessToken);
            }

            // generate Sign
            var sign = Signature.SignRequest(request, AppSecret, path);

            // add params request to url query
            var urlQuery = ToQueryString(request);

            // add sign to url query
            urlQuery += $"&sign={sign}";

            return urlQuery;
        }

        private static string ToQueryString(Dictionary<string, string> queryParams)
        {
            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> queryParam in queryParams)
            {
                list.Add(HttpUtility.UrlEncode(queryParam.Key) + "=" + HttpUtility.UrlEncode(queryParam.Value));
            }

            return string.Join("&", list);
        }
    }
}
