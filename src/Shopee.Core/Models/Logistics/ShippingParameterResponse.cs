using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Logistics
{
    public class ShippingParameterResponse
    {
        [JsonPropertyName("info_needed")]
        public InfoNeeded InfoNeeded { get; set; }

        //[JsonPropertyName("dropoff")]
        //public Dropoff Dropoff { get; set; }

        [JsonPropertyName("pickup")]
        public Pickup Pickup { get; set; }
    }

    public class AddressList
    {
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

        [JsonPropertyName("address_flag")]
        public List<string> AddressFlag { get; set; }

        [JsonPropertyName("time_slot_list")]
        public List<TimeSlotList> TimeSlotList { get; set; }
    }
    /*
    public class Dropoff
    {
        [JsonPropertyName("branch_list")]
        public object BranchList { get; set; }

        [JsonPropertyName("slug_list")]
        public object SlugList { get; set; }
    }
    */
    public class InfoNeeded
    {
        [JsonPropertyName("dropoff")]
        public List<object> Dropoff { get; set; }

        [JsonPropertyName("pickup")]
        public List<string> Pickup { get; set; }
    }

    public class Pickup
    {
        [JsonPropertyName("address_list")]
        public List<AddressList> AddressList { get; set; }
    }

    public class TimeSlotList
    {
        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("pickup_time_id")]
        public string PickupTimeId { get; set; }
    }
}
