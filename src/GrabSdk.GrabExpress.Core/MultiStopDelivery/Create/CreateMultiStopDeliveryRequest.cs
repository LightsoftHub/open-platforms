using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.MultiStopDelivery.Create
{
    public class CreateMultiStopDeliveryRequest : MultiStopDeliveryBase
    {
        public string merchantOrderID { get; set; }
        public string paymentMethod { get; set; }
        public List<Origin> origin { get; set; }
        public List<Destination> destination { get; set; }
    }
}
