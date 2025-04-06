using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Order
{
    public class OrderListDto
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }
    }

    public class OrderListResponse
    {
        [JsonPropertyName("more")]
        public bool More { get; set; }

        [JsonPropertyName("next_cursor")]
        public string NextCursor { get; set; }

        [JsonPropertyName("order_list")]
        public List<OrderListDto> OrderList { get; set; }
    }
}
