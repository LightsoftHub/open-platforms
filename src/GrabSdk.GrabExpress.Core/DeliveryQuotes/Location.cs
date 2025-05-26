using Light.GrabSdk.GrabExpress.Common;

namespace Light.GrabSdk.GrabExpress.DeliveryQuotes
{
    public class Location
    {
        public string address { get; set; }
        public string keywords { get; set; }
        public string cityCode { get; set; }
        public Coordinates coordinates { get; set; }
    }
}
