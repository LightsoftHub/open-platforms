using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class UploadStockResponse
    {
        [JsonPropertyName("field")]
        public string Field { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("sku_id")]
        public long SkuId { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
