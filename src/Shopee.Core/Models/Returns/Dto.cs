using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Returns
{
    public class Item
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("item_price")]
        public double ItemPrice { get; set; }

        [JsonPropertyName("is_add_on_deal")]
        public bool IsAddOnDeal { get; set; }

        [JsonPropertyName("is_main_item")]
        public bool IsMainItem { get; set; }

        [JsonPropertyName("item_sku")]
        public string ItemSku { get; set; }

        [JsonPropertyName("variation_sku")]
        public string VariationSku { get; set; }

        [JsonPropertyName("add_on_deal_id")]
        public long? AddOnDealId { get; set; }
    }

    public class User
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }
    }
}
