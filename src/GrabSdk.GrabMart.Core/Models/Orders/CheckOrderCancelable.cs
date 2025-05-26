using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.GrabSdk.GrabMart.Models.Orders
{
    public class CheckOrderCancelable
    {
        [JsonPropertyName("cancelable")]
        public bool Cancelable { get; set; }

        [JsonPropertyName("nonCancellationReason")]
        public string NonCancellationReason { get; set; } = string.Empty;

        [JsonPropertyName("limitType")]
        public string LimitType { get; set; } = string.Empty;

        [JsonPropertyName("limitTimes")]
        public int LimitTimes { get; set; }

        [JsonPropertyName("cancelReasons")]
        public List<CancelReason> CancelReasons { get; set; }
    }

    public class CancelReason
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;
    }
}