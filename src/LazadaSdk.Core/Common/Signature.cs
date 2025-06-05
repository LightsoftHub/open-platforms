using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Light.Lazada.Common
{
    public class Signature
    {
        public const string SIGN_METHOD_SHA256 = "sha256";

        public static string SignRequest(IDictionary<string, string> parameters, string appSecret, string apiName, string body = null)
        {
            // first : sort all key with asci order
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);

            // second : contact all params with key order
            var query = new StringBuilder();
            query.Append(apiName);
            foreach (KeyValuePair<string, string> kv in sortedParams)
            {
                if (!string.IsNullOrEmpty(kv.Key) && !string.IsNullOrEmpty(kv.Value))
                {
                    query.Append(kv.Key).Append(kv.Value);
                }
            }

            // third : add body to last
            if (!string.IsNullOrEmpty(body))
            {
                query.Append(body);
            }

            var sha256 = new HMACSHA256(Encoding.UTF8.GetBytes(appSecret));
            // next : sign the string
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));

            // finally : transfer binary byte to hex string
            var result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }

            return result.ToString();
        }
    }
}
