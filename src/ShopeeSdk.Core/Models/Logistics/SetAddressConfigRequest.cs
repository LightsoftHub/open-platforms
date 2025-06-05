using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class SetAddressConfigRequest
    {
        //[JsonPropertyName("show_pick_up_address")]
        //public bool ShowPickUpAddress { get; set; }

        [JsonPropertyName("address_type_config")]
        public AddressTypeConfig AddressTypeConfig { get; set; }
    }

    public class AddressTypeConfig
    {
        [JsonPropertyName("address_id")]
        public long AddressId { get; set; }

        [JsonPropertyName("address_type")]
        public List<string> AddressType { get; set; }
    }
}