using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Orders
{
    public class Currency
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("exponent")]
        public int Exponent { get; set; }
    }
}
