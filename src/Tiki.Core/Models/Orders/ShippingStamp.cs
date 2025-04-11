using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Orders
{
    public class ShippingStamp
    {
        [JsonPropertyName("shipping_label_url")]
        public string ShippingLabelUrl { get; set; }

        [JsonPropertyName("shipping_stamp_url")]
        public string ShippingStampUrl { get; set; }
    }
}
