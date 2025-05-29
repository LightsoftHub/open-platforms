using Light.GrabSdk.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.DeliveryQuotes
{
    public class GetDeliveryQuotesResponse
    {
        public List<Quote> quotes { get; set; }
        public Location origin { get; set; }
        public Location destination { get; set; }
        public List<Package> packages { get; set; }
    }

    public class Quote
    {
        public Service service { get; set; }
        public Currency currency { get; set; }
        public double amount { get; set; }
        public EstimatedTimeline estimatedTimeline { get; set; }
        public double distance { get; set; }
    }
}
