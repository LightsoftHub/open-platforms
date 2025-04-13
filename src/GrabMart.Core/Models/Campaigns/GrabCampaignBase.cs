using Light.GrabMart.Enums;
using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Campaigns
{
    public abstract class GrabCampaignBase
    {
        public GrabCampaignBase() { }

        public GrabCampaignBase(string merchantId, string name)
        {
            MerchantID = merchantId;
            Name = name;
        }

        [JsonPropertyName("merchantID")]
        public string MerchantID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quotas")]
        public Quota Quotas { get; set; }

        [JsonPropertyName("conditions")]
        public Condition Conditions { get; set; } = new Condition();

        [JsonPropertyName("discount")]
        public Discount Discount { get; set; } = new Discount();

        public void SetQuotas(int? totalCount, int? totalCountPerUser)
        {
            if (totalCount > 0 || totalCountPerUser > 0)
            {
                Quotas = new Quota(totalCount, totalCountPerUser);
            }
        }

        public void SetRunTime(DateTimeOffset startTime, DateTimeOffset endTime, WorkingHour workingHour)
        {
            Conditions.StartTime = startTime;
            Conditions.EndTime = endTime;
            Conditions.WorkingHour = workingHour;
        }

        public void SetConditions(string eaterType, double minBasketAmount, int bundleQuantity)
        {
            Conditions.EaterType = eaterType.ToLower();
            Conditions.MinBasketAmount = minBasketAmount;
            Conditions.BundleQuantity = bundleQuantity;
        }

        public bool CheckIsNetOff()
        {
            var netOffType = Discount_Type.net.ToString();
            var netOffScopeType = Discount_ScopeType.items.ToString();

#if DEBUG
            // in Staging discount type difference with PROD
            netOffScopeType = "item";
#endif

            return Discount.Type == netOffType && Discount.Scope.Type == netOffScopeType;
        }
    }

    public partial class Discount
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; }

        [JsonPropertyName("cap")]
        public double Cap { get; set; }

        [JsonPropertyName("scope")]
        public Scope Scope { get; set; }
    }

    public partial class Scope
    {
        public Scope() { }

        public Scope(string type)
        {
            Type = type;
        }

        public Scope(string type, string[] objIds)
        {
            Type = type;
            ObjectIDs = objIds;
        }

        public Scope(string type, string objId)
        {
            Type = type;
            ObjectIDs = new string[] { objId };
        }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("objectIDs")]
        public string[] ObjectIDs { get; set; }
    }

    public partial class Quota
    {
        public Quota() { }

        public Quota(int? totalCount, int? totalCountPerUser)
        {
            TotalCount = totalCount > 0 ? totalCount : null;
            TotalCountPerUser = totalCountPerUser > 0 ? totalCountPerUser : null;
        }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

        [JsonPropertyName("totalCountPerUser")]
        public int? TotalCountPerUser { get; set; }
    }

    public partial class Condition
    {
        [JsonPropertyName("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTimeOffset EndTime { get; set; }

        [JsonPropertyName("eaterType")]
        public string EaterType { get; set; }

        [Description("Specify the min basket amount to applied that campaign.\r\nFor example: 10.5 means the basket amount has to be $10.5 at minimum.")]
        [JsonPropertyName("minBasketAmount")]
        public double MinBasketAmount { get; set; }

        [Description("Specify the bundle quantity for bundle offer campaign.\r\nFor example: bundle offer buy 3 get $10 off, the bundleQuantity field should be 3.")]
        [JsonPropertyName("bundleQuantity")]
        public int BundleQuantity { get; set; }

        [JsonPropertyName("workingHour")]
        public WorkingHour WorkingHour { get; set; }
    }
}