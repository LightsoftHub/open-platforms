using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class FeatureFlags
    {
        [JsonPropertyName("orderAcceptedType")]
        public string OrderAcceptedType { get; set; }

        [JsonPropertyName("orderType")]
        public string OrderType { get; set; }

        [JsonPropertyName("isMexEditOrder")]
        public bool IsMexEditOrder { get; set; }
    }
}
