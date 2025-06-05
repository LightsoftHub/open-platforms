using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class UpdateStockRequest
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("stock_list")]
        public List<StockListRequest> StockList { get; set; }
    }

    public class StockListRequest
    {
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        //[JsonPropertyName("normal_stock")]
        //public int NormalStock { get; set; }

        [JsonPropertyName("seller_stock")]
        public List<SellerStockRequest> SellerStock { get; set; }
    }

    public class SellerStockRequest
    {
        [JsonPropertyName("location_id")]
        public string LocationId { get; set; }

        [JsonPropertyName("stock")]
        public int Stock { get; set; }
    }
}
