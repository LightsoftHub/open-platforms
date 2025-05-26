using Light.GrabSdk.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.DeliveryQuotes
{
    public class GetDeliveryQuotesRequest
    {
        public string serviceType { get; set; }
        public string vehicleType { get; set; }
        public string codType { get; set; }
        public List<Package> packages { get; set; }
        public Location origin { get; set; }
        public Location destination { get; set; }
    }
}
