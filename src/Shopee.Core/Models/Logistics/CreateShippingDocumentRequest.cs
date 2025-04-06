using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class CreateShippingDocumentRequest
    {
        [JsonPropertyName("order_sn")]
        public string Ordersn { get; set; }

        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonPropertyName("shipping_document_type")]
        public string ShippingDocumentType { get; set; } = "THERMAL_AIR_WAYBILL"; //"NORMAL_AIR_WAYBILL";
    }
}