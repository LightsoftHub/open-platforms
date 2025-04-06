using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class CategoryListResponse
    {
        [JsonPropertyName("category_list")]
        public List<CategoryList> CategoryList { get; set; }
    }

    public class CategoryList
    {
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("parent_category_id")]
        public int ParentCategoryId { get; set; }

        [JsonPropertyName("original_category_name")]
        public string OriginalCategoryName { get; set; }

        [JsonPropertyName("display_category_name")]
        public string DisplayCategoryName { get; set; }

        [JsonPropertyName("has_children")]
        public bool HasChildren { get; set; }
    }
}