using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Products
{
    public class WarehouseQtyRequest
    {
        [JsonPropertyName("warehouse_id")]
        public long WarehouseId { get; set; }

        [JsonPropertyName("qty_available")]
        public int QtyAvailable { get; set; }
    }
}
