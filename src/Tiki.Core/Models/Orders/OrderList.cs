using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Orders
{
    public class OrderList
    {
        [JsonPropertyName("data")]
        public List<Order> Data { get; set; } = new List<Order>();

        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }
}
