using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class ProductList
    {
        [JsonPropertyName("total_products")]
        public int TotalProducts { get; set; }

        [JsonPropertyName("products")]
        public IEnumerable<Product> Products { get; set; }
    }
}
