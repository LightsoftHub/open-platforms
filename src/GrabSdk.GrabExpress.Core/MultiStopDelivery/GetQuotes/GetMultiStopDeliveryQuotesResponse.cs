using Light.GrabSdk.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.MultiStopDelivery.GetQuotes
{
    public class GetMultiStopDeliveryQuotesResponse
    {
        public List<Quote> quotes { get; set; }
    }

    public class Quote
    {
        public Service service { get; set; }
        public Currency currency { get; set; }
        public List<Address> origin { get; set; }
        public List<Destination> destination { get; set; }
        public double distance { get; set; }
    }
}
