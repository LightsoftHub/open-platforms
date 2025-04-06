using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Public
{
    public class IpListResponse : ShopeeResult
    {
        [JsonPropertyName("ip_list")]
        public List<string> IpList { get; set; }
    }
}
