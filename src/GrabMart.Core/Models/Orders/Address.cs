using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Orders
{
    public class Address
    {
        [JsonPropertyName("unitNumber")]
        public string UnitNumber { get; set; }

        [JsonPropertyName("deliveryInstruction")]
        public string DeliveryInstruction { get; set; }

        [JsonPropertyName("poiSource")]
        public string PoiSource { get; set; }

        [JsonPropertyName("poiID")]
        public string PoiID { get; set; }

        [JsonPropertyName("address")]
        public string AddressInfo { get; set; }

        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}
