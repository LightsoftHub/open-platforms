using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Orders
{
    public class Price
    {
        [JsonPropertyName("subtotal")]
        public decimal Subtotal { get; set; }

        [JsonPropertyName("tax")]
        public decimal Tax { get; set; }

        [JsonPropertyName("deliveryFee")]
        public decimal DeliveryFee { get; set; }

        [JsonPropertyName("eaterPayment")]
        public decimal EaterPayment { get; set; }

        [JsonPropertyName("grabFundPromo")]
        public decimal GrabFundPromo { get; set; }

        [JsonPropertyName("merchantFundPromo")]
        public decimal MerchantFundPromo { get; set; }

        [JsonPropertyName("merchantChargeFee")]
        public decimal MerchantChargeFee { get; set; }

        [JsonPropertyName("basketPromo")]
        public decimal BasketPromo { get; set; }

        [JsonPropertyName("smallOrderFee")]
        public decimal SmallOrderFee { get; set; }
    }
}
