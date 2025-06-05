using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class Receiver
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phones")]
        public string Phones { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }
    }
}