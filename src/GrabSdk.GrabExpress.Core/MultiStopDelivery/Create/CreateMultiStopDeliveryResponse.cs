using Light.GrabSdk.GrabExpress.Common;
using System;
using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.MultiStopDelivery.Create
{
    public class CreateMultiStopDeliveryResponse
    {
        public string merchantOrderID { get; set; }
        public string paymentMethod { get; set; }
        public Quote quote { get; set; }
    }

    public class EstimatedTimeline
    {
        public DateTime pickup { get; set; }
        public DateTime dropoff { get; set; }
        public DateTime completed { get; set; }
    }

    public class Quote
    {
        public Service service { get; set; }
        public Currency currency { get; set; }
        public List<Origin> origin { get; set; }
        public List<DestinationResponse> destination { get; set; }
        public double distance { get; set; }
    }

    public class DestinationResponse : Destination
    {
        public int amount { get; set; }
        public EstimatedTimeline estimatedTimeline { get; set; }
        public string deliveryID { get; set; }
        public string status { get; set; }
    }
}
