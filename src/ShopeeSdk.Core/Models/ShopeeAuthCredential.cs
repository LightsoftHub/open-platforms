using Light.Shopee.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Light.Shopee.Models
{
    public class ShopeeAuthCredential
    {
        protected readonly string _baseUrl;

        protected readonly string _secretKey;

        public ShopeeAuthCredential(string baseUrl, long partnerId, string secretKey)
        {
            _baseUrl = baseUrl;
            PartnerId = partnerId;
            _secretKey = secretKey;
        }

        public long PartnerId { get; }

        public string Sign { get; protected set; }

        public long Timestamp { get; protected set; }

        public virtual string GenerateSignedUrl(string path)
        {
            Timestamp = DateTime.Now.ToUnixTimeSeconds();

            var baseString = $"{PartnerId}{path}{Timestamp}";

            Sign = CalculatingSignature.GenerateSignature(_secretKey, baseString);

            var requestParams = new Dictionary<string, object>()
            {
                { "partner_id", PartnerId },
                { "timestamp", Timestamp },
                { "sign", Sign },
            };

            var urlParams = string.Join("&", requestParams.Select(s => $"{s.Key}={s.Value}"));

            return $"{_baseUrl}{path}?{urlParams}";
        }
    }
}