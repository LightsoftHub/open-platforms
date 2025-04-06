using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Payment
{
    public class EscrowList
    {
        [JsonPropertyName("escrow_release_time")]
        public long EscrowReleaseTime { get; set; }

        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("payout_amount")]
        public decimal PayoutAmount { get; set; }
    }

    public class EscrowListResponse
    {
        [JsonPropertyName("escrow_list")]
        public List<EscrowList> EscrowList { get; set; }

        [JsonPropertyName("more")]
        public bool More { get; set; }
    }
}
