using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class ItemPromotionResponse
    {
        [JsonPropertyName("success_list")]
        public List<SuccessList> SuccessList { get; set; }

        [JsonPropertyName("failure_list")]
        public List<FailureList> FailureList { get; set; }
    }

    public class FailureList
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("failed_reason")]
        public string FailedReason { get; set; }
    }

    public class Promotion
    {
        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }

        [JsonPropertyName("promotion_id")]
        public long PromotionId { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("start_time")]
        public int StartTime { get; set; }

        [JsonPropertyName("end_time")]
        public int EndTime { get; set; }

        [JsonPropertyName("promotion_price_info")]
        public List<PromotionPriceInfo> PromotionPriceInfo { get; set; }

        [JsonPropertyName("reserved_stock_info")]
        public List<ReservedStockInfo> ReservedStockInfo { get; set; }

        [JsonPropertyName("promotion_staging")]
        public string PromotionStaging { get; set; }
    }

    public class PromotionPriceInfo
    {
        [JsonPropertyName("promotion_price")]
        public int PromotionPrice { get; set; }
    }

    public class ReservedStockInfo
    {
        [JsonPropertyName("stock_type")]
        public int StockType { get; set; }

        [JsonPropertyName("stock_location_id")]
        public string StockLocationId { get; set; }

        [JsonPropertyName("reserved_stock")]
        public int ReservedStock { get; set; }
    }

    public class SuccessList
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("promotion")]
        public List<Promotion> Promotion { get; set; }
    }
}
