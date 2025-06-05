using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class ShippingDocumentParameterResponse
    {
        [JsonPropertyName("result_list")]
        public List<ResultList> ResultList { get; set; }
    }

    public class ResultList
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("suggest_shipping_document_type")]
        public string SuggestShippingDocumentType { get; set; }

        [JsonPropertyName("selectable_shipping_document_type")]
        public List<string> SelectableShippingDocumentType { get; set; }

        [JsonPropertyName("fail_error")]
        public string FailError { get; set; }

        [JsonPropertyName("fail_message")]
        public string FailMessage { get; set; }
    }

    public class Warning
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }
    }
}
