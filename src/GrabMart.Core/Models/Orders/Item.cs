using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Orders
{
    public class Item
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("specifications")]
        public string Specifications { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("modifiers")]
        public object[] Modifiers { get; set; }

        [JsonPropertyName("grabItemID")]
        public string GrabItemID { get; set; }

        [JsonPropertyName("tax")]
        public decimal Tax { get; set; }
    }
}
