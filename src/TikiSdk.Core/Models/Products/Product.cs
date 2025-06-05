using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Products
{
    public class Product
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("master_id")]
        public int MasterId { get; set; }

        [JsonPropertyName("master_sku")]
        public string MasterSku { get; set; }

        [JsonPropertyName("super_id")]
        public int SuperId { get; set; }

        [JsonPropertyName("super_sku")]
        public string SuperSku { get; set; }

        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("original_sku")]
        public string OriginalSku { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("market_price")]
        public int MarketPrice { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        [JsonPropertyName("inventory")]
        public Inventory Inventory { get; set; }
    }

    public class Attributes
    {
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url_key")]
        public string UrlKey { get; set; }

        [JsonPropertyName("is_primary")]
        public bool IsPrimary { get; set; }
    }

    public class Inventory
    {
        [JsonPropertyName("inventory_type")]
        public string InventoryType { get; set; }

        [JsonPropertyName("fulfillment_type")]
        public string FulfillmentType { get; set; }

        [JsonPropertyName("warehouse_stocks")]
        public List<WarehouseStock> WarehouseStocks { get; set; }
    }

    public class WarehouseStock
    {
        [JsonPropertyName("warehouse_id")]
        public int WarehouseId { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("quantity_available")]
        public int QuantityAvailable { get; set; }

        [JsonPropertyName("quantity_sellable")]
        public int QuantitySellable { get; set; }

        [JsonPropertyName("quantity_reserved")]
        public int QuantityReserved { get; set; }
    }
}
