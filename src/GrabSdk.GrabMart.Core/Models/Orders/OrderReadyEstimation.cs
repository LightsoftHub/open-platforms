using System;
using System.Text.Json.Serialization;

namespace Light.GrabSdk.GrabMart.Models.Orders
{
    public class OrderReadyEstimation
    {
        [JsonPropertyName("allowChange")]
        public bool AllowChange { get; set; }

        [JsonPropertyName("estimatedOrderReadyTime")]
        public DateTime? EstimatedOrderReadyTime { get; set; }

        [JsonPropertyName("maxOrderReadyTime")]
        public DateTime? MaxOrderReadyTime { get; set; }
    }
}
