namespace Light.Grab.GrabExpress.Delivery
{
    public class Location : Common.Address
    {
        public string keywords { get; set; }

        /// <summary>
        /// Required for address resolution when certain partners don’t send latitude, longitude values.
        ///     https://developer.grab.com/docs/grab-express-city-codes
        /// </summary>
        public string cityCode { get; set; }
    }
}
