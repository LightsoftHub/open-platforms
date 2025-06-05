using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class AddressListResponse
    {
        [JsonPropertyName("show_pickup_address")]
        public bool ShowPickupAddress { get; set; }

        [JsonPropertyName("address_list")]
        public List<AddressInfo> AddressList { get; set; }
    }

    public class AddressInfo
    {
        [JsonPropertyName("address_id")]
        public int AddressId { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("town")]
        public string Town { get; set; }

        [JsonPropertyName("address_type")]
        public List<string> AddressType { get; set; }
    }
}