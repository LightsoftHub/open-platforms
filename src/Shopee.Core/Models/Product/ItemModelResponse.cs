using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class ItemModelResponse
    {
        [JsonPropertyName("tier_variation")]
        public List<TierVariation> TierVariation { get; set; }

        [JsonPropertyName("model")]
        public List<Model> Model { get; set; }
    }

    public class ItemModelImageResponse
    {
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }

    public class Model
    {
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("promotion_id")]
        public long PromotionId { get; set; }

        [JsonPropertyName("tier_index")]
        public List<int> TierIndex { get; set; }

        [JsonPropertyName("stock_info")]
        public List<ItemModelStockInfoResponse> StockInfo { get; set; }

        [JsonPropertyName("price_info")]
        public List<ItemModelPriceInfoResponse> PriceInfo { get; set; }

        [JsonPropertyName("model_sku")]
        public string ModelSku { get; set; }

        [JsonPropertyName("pre_order")]
        public ItemModelPreOrderResponse PreOrder { get; set; }
    }

    public class OptionList
    {
        [JsonPropertyName("option")]
        public string Option { get; set; }

        [JsonPropertyName("image")]
        public ItemModelImageResponse Image { get; set; }
    }

    public class ItemModelPreOrderResponse
    {
        [JsonPropertyName("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName("days_to_ship")]
        public int DaysToShip { get; set; }
    }

    public class ItemModelPriceInfoResponse
    {
        [JsonPropertyName("current_price")]
        public int CurrentPrice { get; set; }

        [JsonPropertyName("original_price")]
        public int OriginalPrice { get; set; }

        [JsonPropertyName("inflated_price_of_current_price")]
        public int InflatedPriceOfCurrentPrice { get; set; }

        [JsonPropertyName("inflated_price_of_original_price")]
        public int InflatedPriceOfOriginalPrice { get; set; }
    }

    public class ItemModelStockInfoResponse
    {
        [JsonPropertyName("stock_type")]
        public int StockType { get; set; }

        [JsonPropertyName("stock_location_id")]
        public string StockLocationId { get; set; }

        [JsonPropertyName("current_stock")]
        public int CurrentStock { get; set; }

        [JsonPropertyName("normal_stock")]
        public int NormalStock { get; set; }

        [JsonPropertyName("reserved_stock")]
        public int ReservedStock { get; set; }
    }

    public class TierVariation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("option_list")]
        public List<OptionList> OptionList { get; set; }
    }
}
