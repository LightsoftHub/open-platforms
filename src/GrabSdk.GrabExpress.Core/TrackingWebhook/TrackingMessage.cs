namespace Light.GrabSdk.GrabExpress.TrackingWebhook
{
    public class TrackingMessage
    {
        public string deliveryID { get; set; }
        public string merchantOrderID { get; set; }
        public int timestamp { get; set; }
        public string status { get; set; }
        public string trackURL { get; set; }
        public string pickupPin { get; set; }
        public string failedReason { get; set; }
        public Sender sender { get; set; }
        public Recipient recipient { get; set; }
        public Driver driver { get; set; }
    }

    public class Driver
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string licensePlate { get; set; }
        public string photoURL { get; set; }
        public double currentLat { get; set; }
        public double currentLng { get; set; }
    }

    public class Recipient
    {
        public string name { get; set; }
        public string address { get; set; }
        public string relationship { get; set; }
    }

    public class Sender
    {
        public string name { get; set; }
        public string address { get; set; }
        public string relationship { get; set; }
    }
}
