using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Products
{
    public class ProductsList
    {
        [JsonPropertyName("data")]
        public List<Product> Data { get; set; }

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }
}
