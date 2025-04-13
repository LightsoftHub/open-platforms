using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Orders
{
    public class Promo
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("promoAmount")]
        public decimal PromoAmount { get; set; }

        [JsonPropertyName("mexFundedRatio")]
        public decimal MexFundedRatio { get; set; }

        [JsonPropertyName("mexFundedAmount")]
        public decimal MexFundedAmount { get; set; }

        [JsonPropertyName("targetedPrice")]
        public decimal TargetedPrice { get; set; }

        [JsonPropertyName("promoAmountInMin")]
        public decimal PromoAmountInMin { get; set; }
    }
}
