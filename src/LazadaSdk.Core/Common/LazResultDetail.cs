using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazResultDetail : LazResult
    {
        [JsonPropertyName("detail")]
        public List<Detail> Detail { get; set; }
    }

    public class Detail
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("seller_sku")]
        public string SellerSku { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
