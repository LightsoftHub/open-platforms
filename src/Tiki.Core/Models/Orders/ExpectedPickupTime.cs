using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Orders
{
    public class ExpectedPickupTime
    {
        [JsonPropertyName("seller_id")]
        public int SellerId { get; set; }

        [JsonPropertyName("pickup_slots")]
        public List<PickupSlot> PickupSlots { get; set; }
    }

    public class PickupSlot
    {
        [JsonPropertyName("expected_pickup_slot")]
        public string ExpectedPickupSlot { get; set; }

        [JsonPropertyName("expected_pickup_time")]
        public string ExpectedPickupTime { get; set; }
    }

}