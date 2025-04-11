using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Orders
{
    public class OrdersList
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("countTotal")]
        public int CountTotal { get; set; }

        [JsonPropertyName("orders")]
        public IEnumerable<Order> Orders { get; set; }
    }
}
