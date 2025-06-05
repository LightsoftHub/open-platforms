using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.PushConfig
{
    public class SetPushConfigRequest
    {
        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonPropertyName("live_push_status")]
        public string LivePushStatus { get; set; }

        [JsonPropertyName("blocked_shop_id_list")]
        public List<long> BlockedShopIdList { get; set; }

        [JsonPropertyName("push_config_on_list")]
        public List<int> PushConfigOnList { get; set; }

        [JsonPropertyName("push_config_off_list")]
        public List<int> PushConfigOffList { get; set; }
    }
}
