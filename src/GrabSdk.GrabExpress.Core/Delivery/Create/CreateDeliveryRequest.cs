using Light.Grab.GrabExpress.Common;
using Light.Grab.GrabExpress.Common.Enums;
using System.Collections.Generic;

namespace Light.Grab.GrabExpress.Delivery.Create
{
    public class CreateDeliveryRequest
    {
        public string merchantOrderID { get; set; }
        public string serviceType { get; private set; }
        public string vehicleType { get; private set; }
        public string codType { get; set; }
        public string paymentMethod { get; private set; }
        public bool highValue { get; set; }
        public List<Package> packages { get; set; }
        public CashOnDelivery cashOnDelivery { get; set; }
        public Location origin { get; set; }
        public Location destination { get; set; }
        public ContactInfo recipient { get; set; }
        public ContactInfo sender { get; set; }
        public Schedule schedule { get; set; }

        public void SetServiceType(ServiceType value) =>
            serviceType = value.ToString();

        public void SetVehicleType(VehicleType value = VehicleType.BIKE) =>
            vehicleType = value.ToString();

        public void SetCod(CodType value) =>
            codType = value.ToString();

        public void SetCodAmount(double codAmount)
        {
            paymentMethod = PaymentMethod.CASH.ToString();
            cashOnDelivery = new CashOnDelivery
            {
                amount = codAmount,
            };
        }
    }
}
