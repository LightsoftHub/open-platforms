using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class ItemListResponse
    {
        [JsonPropertyName("item")]
        public List<Item> Item { get; set; }

        [JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        [JsonPropertyName("next_offset")]
        public int? NextOffset { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }
    }
}
