using Light.Grab.GrabMart.Enums;

namespace Light.Grab.GrabMart.Models.Campaigns
{
    public class Campaign : GrabCampaignBase
    {
        public Campaign(string merchantId, string name) : base(merchantId, name)
        {
        }

        public void SetNetOff(double value, string[] objIds)
        {
            Discount.Type = Discount_Type.net.ToString();
            Discount.Value = value;

            var netOffScopeType = Discount_ScopeType.items.ToString();

#if DEBUG
            // in Staging discount type difference with PROD
            netOffScopeType = "item";
#endif

            Discount.Scope = new Scope(netOffScopeType, objIds);
        }

        public void SetFreeItem(string itemNo)
        {
            Discount.Type = Discount_Type.freeItem.ToString();

            var discType = Discount_ScopeType.items.ToString();

            Discount.Scope = new Scope(discType, itemNo);
        }

        public void SetBundleSame(string type, double value, string itemNo)
        {
            Discount.Type = type;
            Discount.Value = value;

            var discType = Discount_ScopeType.items.ToString();

            Discount.Scope = new Scope(discType, itemNo);
        }

        public void SetBundleDiff(string type, double value, string[] items)
        {
            Discount.Type = type;
            Discount.Value = value;

            var discType = Discount_ScopeType.items.ToString();

            Discount.Scope = new Scope(discType, items);
        }
    }

}