using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class Sku
    {
        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("Images")]
        public List<object> Images { get; set; }

        [JsonPropertyName("SellerSku")]
        public string SellerSku { get; set; }

        [JsonPropertyName("ShopSku")]
        public string ShopSku { get; set; }

        [JsonPropertyName("saleProp")]
        public SaleProp SaleProp { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("multiWarehouseInventories")]
        public List<MultiWarehouseInventory> MultiWarehouseInventories { get; set; }

        [JsonPropertyName("package_width")]
        public string PackageWidth { get; set; }

        [JsonPropertyName("package_height")]
        public string PackageHeight { get; set; }

        [JsonPropertyName("fblWarehouseInventories")]
        public List<object> FblWarehouseInventories { get; set; }

        [JsonPropertyName("special_price")]
        public double SpecialPrice { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("channelInventories")]
        public List<object> ChannelInventories { get; set; }

        [JsonPropertyName("package_length")]
        public string PackageLength { get; set; }

        [JsonPropertyName("package_weight")]
        public string PackageWeight { get; set; }

        [JsonPropertyName("Available")]
        public int Available { get; set; }

        [JsonPropertyName("SkuId")]
        public long SkuId { get; set; }
    }
}
