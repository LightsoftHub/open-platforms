using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class Order
    {
        [JsonPropertyName("orderID")]
        public string OrderID { get; set; }

        [JsonPropertyName("completeTime")]
        public DateTime? CompleteTime { get; set; }

        [JsonPropertyName("orderTime")]
        public DateTime OrderTime { get; set; }

        [JsonPropertyName("orderState")]
        public string OrderState { get; set; }

        [JsonPropertyName("merchantID")]
        public string MerchantID { get; set; }

        [JsonPropertyName("partnerMerchantID")]
        public string PartnerMerchantID { get; set; }

        [JsonPropertyName("shortOrderNumber")]
        public string ShortOrderNumber { get; set; }

        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("cutlery")]
        public bool Cutlery { get; set; }

        [JsonPropertyName("items")]
        public Item[] Items { get; set; }

        [JsonPropertyName("price")]
        public Price Price { get; set; }

        [JsonPropertyName("featureFlags")]
        public FeatureFlags FeatureFlags { get; set; }

        [JsonPropertyName("submitTime")]
        public DateTime? SubmitTime { get; set; }

        [JsonPropertyName("receiver")]
        public Receiver Receiver { get; set; }

        [JsonPropertyName("campaigns")]
        public Campaign[] Campaigns { get; set; }

        [JsonPropertyName("dineIn")]
        public DineIn DineIn { get; set; }

        [JsonPropertyName("scheduledTime")]
        public string ScheduledTime { get; set; }

        [JsonPropertyName("membershipID")]
        public string MembershipID { get; set; }

        [JsonPropertyName("orderReadyEstimation")]
        public OrderReadyEstimation OrderReadyEstimation { get; set; }

        [JsonPropertyName("promos")]
        public IEnumerable<Promo> Promos { get; set; }
    }
}