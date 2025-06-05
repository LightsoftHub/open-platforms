using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Fulfillments
{
    public class ShipmentProviderData
    {
        [JsonPropertyName("platform_default")]
        public object PlatformDefault { get; set; }

        [JsonPropertyName("shipment_providers")]
        public List<ShipmentProvider> ShipmentProviders { get; set; }

        [JsonPropertyName("shipping_allocate_type")]
        public string ShippingAllocateType { get; set; }
    }

    public class ShipmentProviderResult
    {
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        [JsonPropertyName("data")]
        public ShipmentProviderData Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }
    }

    public class ShipmentProvider
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("provider_code")]
        public string ProviderCode { get; set; }
    }
}
