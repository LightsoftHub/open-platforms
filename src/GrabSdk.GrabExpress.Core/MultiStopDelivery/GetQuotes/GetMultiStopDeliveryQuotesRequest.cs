using Light.GrabSdk.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.MultiStopDelivery.GetQuotes
{
    public class GetMultiStopDeliveryQuotesRequest : MultiStopDeliveryBase
    {
        public List<Address> origin { get; set; }
        public List<Destination> destination { get; set; }
    }
}
