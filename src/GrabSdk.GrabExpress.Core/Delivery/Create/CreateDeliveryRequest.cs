using Light.Grab.GrabExpress.Common;
using System.Collections.Generic;

namespace Light.Grab.GrabExpress.Delivery.Create
{
    public class CreateDeliveryRequest
    {
        public string merchantOrderID { get; set; }
        public string serviceType { get; set; }
        public string vehicleType { get; set; }
        public string codType { get; set; }
        public string paymentMethod { get; set; }
        public bool highValue { get; set; }
        public List<Package> packages { get; set; }
        public Location origin { get; set; }
        public Location destination { get; set; }
        public ContactInfo recipient { get; set; }
        public ContactInfo sender { get; set; }
        public Schedule schedule { get; set; }
    }
}
