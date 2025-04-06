using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class TrackingNumberResponse
    {
        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonPropertyName("hint")]
        public string Hint { get; set; }
    }
}