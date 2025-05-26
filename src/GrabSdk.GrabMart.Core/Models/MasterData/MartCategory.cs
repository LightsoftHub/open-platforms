using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.GrabSdk.GrabMart.Models.MasterData
{
    public class MartCategory
    {
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }
    }

    public class Category
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("subCategories")]
        public List<SubCategory> SubCategories { get; set; }
    }

    public class SubCategory
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
