using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class ShippingDocumentStatusResponse
    {
        [JsonPropertyName("result_list")]
        public List<ShippingDocumentStatusResultList> ResultList { get; set; }
    }

    public class ShippingDocumentStatusResultList
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("fail_error")]
        public string FailError { get; set; }

        [JsonPropertyName("fail_message")]
        public string FailMessage { get; set; }
    }
}
