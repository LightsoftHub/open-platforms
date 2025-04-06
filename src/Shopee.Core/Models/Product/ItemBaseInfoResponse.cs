using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class ItemBaseInfoResponse
    {
        [JsonPropertyName("item_list")]
        public List<ItemList> ItemList { get; set; }
    }

    public class Brand
    {
        [JsonPropertyName("brand_id")]
        public long BrandId { get; set; }

        [JsonPropertyName("original_brand_name")]
        public string OriginalBrandName { get; set; }
    }

    public class Dimension
    {
        [JsonPropertyName("package_length")]
        public int PackageLength { get; set; }

        [JsonPropertyName("package_width")]
        public int PackageWidth { get; set; }

        [JsonPropertyName("package_height")]
        public int PackageHeight { get; set; }
    }

    public class Image
    {
        [JsonPropertyName("image_url_list")]
        public List<string> ImageUrlList { get; set; }

        [JsonPropertyName("image_id_list")]
        public List<string> ImageIdList { get; set; }
    }

    public class ItemList
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("category_id")]
        public long CategoryId { get; set; }

        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("item_sku")]
        public string ItemSku { get; set; }

        [JsonPropertyName("create_time")]
        public int CreateTime { get; set; }

        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }

        [JsonPropertyName("price_info")]
        public List<PriceInfo> PriceInfo { get; set; }

        [JsonPropertyName("stock_info")]
        public List<StockInfo> StockInfo { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }

        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        [JsonPropertyName("dimension")]
        public Dimension Dimension { get; set; }

        [JsonPropertyName("logistic_info")]
        public List<LogisticInfo> LogisticInfo { get; set; }

        [JsonPropertyName("pre_order")]
        public PreOrder PreOrder { get; set; }

        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        [JsonPropertyName("size_chart")]
        public string SizeChart { get; set; }

        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        [JsonPropertyName("has_model")]
        public bool HasModel { get; set; }

        [JsonPropertyName("promotion_id")]
        public long PromotionId { get; set; }

        [JsonPropertyName("brand")]
        public Brand Brand { get; set; }

        [JsonPropertyName("item_dangerous")]
        public int ItemDangerous { get; set; }

        [JsonPropertyName("description_type")]
        public string DescriptionType { get; set; }
    }

    public class LogisticInfo
    {
        [JsonPropertyName("logistic_id")]
        public long LogisticId { get; set; }

        [JsonPropertyName("logistic_name")]
        public string LogisticName { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        [JsonPropertyName("is_free")]
        public bool IsFree { get; set; }

        [JsonPropertyName("estimated_shipping_fee")]
        public int EstimatedShippingFee { get; set; }
    }

    public class PreOrder
    {
        [JsonPropertyName("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonPropertyName("days_to_ship")]
        public int DaysToShip { get; set; }
    }

    public class PriceInfo
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("original_price")]
        public int OriginalPrice { get; set; }

        [JsonPropertyName("current_price")]
        public int CurrentPrice { get; set; }
    }

    public class StockInfo
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
}