using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class MultiWarehouseInventory
    {
        [JsonPropertyName("occupyQuantity")]
        public int OccupyQuantity { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonPropertyName("withholdQuantity")]
        public int WithholdQuantity { get; set; }

        [JsonPropertyName("warehouseCode")]
        public string WarehouseCode { get; set; }

        [JsonPropertyName("sellableQuantity")]
        public int SellableQuantity { get; set; }
    }
}
