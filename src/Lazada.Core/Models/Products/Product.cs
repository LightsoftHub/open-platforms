using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class Product
    {
        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        [JsonPropertyName("updated_time")]
        public string UpdatedTime { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        [JsonPropertyName("skus")]
        public List<Sku> Skus { get; set; }

        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("variation")]
        public Variation Variation { get; set; }

        [JsonPropertyName("trialProduct")]
        public bool TrialProduct { get; set; }

        [JsonPropertyName("primary_category")]
        public int PrimaryCategory { get; set; }

        [JsonPropertyName("marketImages")]
        public List<object> MarketImages { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class SaleProp
    {
    }

    public class Variation
    {
    }
}
