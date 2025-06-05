using System.ComponentModel;

namespace Light.Grab.GrabMart.Enums
{
    public enum Discount_Type
    {
        [Description("Dollar off")]
        net,

        [Description("Percentage off")]
        percentage,

        [Description("Delivery fee off")]
        delivery,

        [Description("Free item promotion")]
        freeItem,
    }
}
