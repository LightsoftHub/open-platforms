using Light.Grab.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.Grab.GrabExpress.Delivery.GetQuotes
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
