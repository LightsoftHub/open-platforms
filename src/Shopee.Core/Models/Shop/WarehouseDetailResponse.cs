using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Shop
{
    public class WarehouseDetailResponse
    {
        public long warehouse_id { get; set; }

        public string warehouse_name { get; set; }

        public string location_id { get; set; }

        public long address_id { get; set; }

        public string region { get; set; }

        public string state { get; set; }

        public string city { get; set; }

        public string district { get; set; }

        public string town { get; set; }

        public string address { get; set; }

        public string zipcode { get; set; }

        public string state_code { get; set; }

        public int holiday_mode_state { get; set; }
    }
}
