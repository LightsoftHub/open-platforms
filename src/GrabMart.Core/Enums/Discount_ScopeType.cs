using System.ComponentModel;

namespace Light.GrabMart.Enums
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
