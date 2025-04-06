using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Shop
{
    public class WarehouseDetailResponse
    {
        [JsonPropertyName("warehouse_id")]
        public long WarehouseId { get; set; }

        [JsonPropertyName("warehouse_name")]
        public string WarehouseName { get; set; }

        [JsonPropertyName("location_id")]
        public string LocationId { get; set; }

        [JsonPropertyName("address_id")]
        public long AddressId { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("town")]
        public string Town { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }

        [JsonPropertyName("state_code")]
        public string StateCode { get; set; }

        [JsonPropertyName("holiday_mode_state")]
        public int HolidayModeState { get; set; }
    }
}
