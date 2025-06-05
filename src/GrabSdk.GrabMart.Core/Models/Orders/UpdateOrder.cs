using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class UpdateOrder
    {
        [JsonPropertyName("orderID")]
        public string OrderID { get; set; }

        [JsonPropertyName("items")]
        public UpdateItem[] Items { get; set; }

        [JsonPropertyName("onlyRecalculate")]
        public bool OnlyRecalculate { get; set; }
    }

    public class UpdateItem
    {
        [JsonPropertyName("itemID")]
        public string ItemID { get; set; }

        [JsonPropertyName("status")]
        public string Status => Quantity > 0 ? "UPDATED" : "DELETED";

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
