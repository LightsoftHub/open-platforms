using Light.Grab.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.Grab.GrabExpress.MultiStopDelivery.GetQuotes
{
    public class GetMultiStopDeliveryQuotesRequest : MultiStopDeliveryBase
    {
        public List<Address> origin { get; set; }
        public List<Destination> destination { get; set; }
    }
}
