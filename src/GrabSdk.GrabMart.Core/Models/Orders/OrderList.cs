using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class OrderList
    {
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }

        [JsonPropertyName("more")]
        public bool More { get; set; }
    }
}