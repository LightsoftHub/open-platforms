namespace Light.GrabSdk.GrabExpress.Common
{
    public class Package
    {
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Dimensions dimensions { get; set; }
    }
}
