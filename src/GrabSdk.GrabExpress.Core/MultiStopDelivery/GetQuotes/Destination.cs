using Light.Grab.GrabExpress.Common;
using System;
using System.Collections.Generic;

namespace Light.Grab.GrabExpress.MultiStopDelivery.GetQuotes
{
    public class Destination : Address
    {
        public double amount { get; set; }
        public EstimatedTimeline estimatedTimeline { get; set; }
        public List<Package> packages { get; set; }
    }

    public class EstimatedTimeline
    {
        public DateTime pickup { get; set; }
        public DateTime dropoff { get; set; }
        public DateTime completed { get; set; }
    }
}
