using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class TrackingInfoResponse
    {
        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }

        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("tracking_info")]
        public List<TrackingInfo> TrackingInfo { get; set; }
    }

    public class TrackingInfo
    {
        [JsonPropertyName("update_time")]
        public long UpdateTime { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }
    }
}
