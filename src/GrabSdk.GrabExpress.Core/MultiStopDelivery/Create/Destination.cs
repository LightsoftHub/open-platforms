using System.Collections.Generic;

namespace Light.GrabSdk.GrabExpress.MultiStopDelivery.Create
{
    public class Destination : Origin
    {
        public List<Package> packages { get; set; }
    }
}
