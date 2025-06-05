namespace Light.Grab.GrabExpress.MultiStopDelivery
{
    public abstract class MultiStopDeliveryBase
    {
        public string serviceType => "MULTI_STOP";
        public string vehicleType { get; set; }
        public string codType { get; set; }
        public bool routeOptimized { get; set; }
    }
}
