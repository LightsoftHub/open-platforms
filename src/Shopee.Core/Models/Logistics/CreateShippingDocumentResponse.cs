using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class CreateShippingDocumentResponse
    {
        [JsonPropertyName("result_list")]
        public List<CreateShippingDocumentResultList> ResultList { get; set; }
    }

    public class CreateShippingDocumentResultList
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("fail_error")]
        public string FailError { get; set; }

        [JsonPropertyName("fail_message")]
        public string FailMessage { get; set; }

        [JsonIgnore]
        public bool IsSuccess => string.IsNullOrEmpty(FailError) && string.IsNullOrEmpty(FailMessage);
    }
}
