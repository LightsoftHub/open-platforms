using Light.Shopee.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Light.Shopee.Models
{
    public class ShopeeApiCredential : ShopeeAuthCredential
    {
        private readonly long _shopId;

        private readonly string _accessToken;

        public ShopeeApiCredential(string baseUrl, long partnerId, long shopId, string secretKey, string accessToken) : base(baseUrl, partnerId, secretKey)
        {
            _shopId = shopId;
            _accessToken = accessToken;
        }

        public override string GenerateSignedUrl(string path)
        {
            Timestamp = DateTime.Now.ToUnixTimeSeconds();

            var baseString = $"{PartnerId}{path}{Timestamp}{_accessToken}{_shopId}";

            Sign = CalculatingSignature.GenerateSignature(_secretKey, baseString);

            var requestParams = new Dictionary<string, object>()
            {
                { "partner_id", PartnerId },
                { "shop_id", _shopId },
                { "access_token", _accessToken },
                { "timestamp", Timestamp },
                { "sign", Sign },
            };

            var urlParams = string.Join("&", requestParams.Select(s => $"{s.Key}={s.Value}"));

            return $"{_baseUrl}{path}?{urlParams}";
        }
    }
}