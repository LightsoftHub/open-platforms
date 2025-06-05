using System.ComponentModel;

namespace Light.Grab.GrabMart.Enums
{
    public enum Discount_ScopeType
    {
        [Description("Order level campaign")]
        order,

        [Description("Item level campaign or bundle offer")]
        items,

        [Description("Item level campaign or bundle offer")]
        category,
    }
}
