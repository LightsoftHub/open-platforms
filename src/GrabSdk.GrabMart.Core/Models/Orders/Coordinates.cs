using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class Coordinates
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}