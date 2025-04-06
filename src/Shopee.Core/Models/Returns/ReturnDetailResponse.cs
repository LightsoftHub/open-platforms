using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Returns
{
    public partial class ReturnDetailResponse
    {
        [JsonPropertyName("image")]
        public List<object> Image { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("text_reason")]
        public string TextReason { get; set; }

        [JsonPropertyName("return_sn")]
        public string ReturnSn { get; set; }

        [JsonPropertyName("refund_amount")]
        public decimal RefundAmount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("create_time")]
        public int CreateTime { get; set; }

        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("due_date")]
        public int DueDate { get; set; }

        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonPropertyName("needs_logistics")]
        public bool NeedsLogistics { get; set; }

        [JsonPropertyName("amount_before_discount")]
        public long AmountBeforeDiscount { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; } = new User();

        [JsonPropertyName("item")]
        public List<Item> Item { get; set; }

        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("return_ship_due_date")]
        public long ReturnShipDueDate { get; set; }

        [JsonPropertyName("return_seller_due_date")]
        public long ReturnSellerDueDate { get; set; }

        [JsonPropertyName("activity")]
        public List<object> Activity { get; set; }

        [JsonPropertyName("seller_proof")]
        public SellerProof SellerProof { get; set; }

        [JsonPropertyName("seller_compensation")]
        public SellerCompensation SellerCompensation { get; set; }

        [JsonPropertyName("negotiation")]
        public Negotiation Negotiation { get; set; }

        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }

        [JsonPropertyName("return_pickup_address")]
        public ReturnPickupAddress ReturnPickupAddress { get; set; }
    }

    public partial class Negotiation
    {
        [JsonPropertyName("negotiation_status")]
        public string NegotiationStatus { get; set; }

        [JsonPropertyName("latest_solution")]
        public string LatestSolution { get; set; }

        [JsonPropertyName("latest_offer_amount")]
        public object LatestOfferAmount { get; set; }

        [JsonPropertyName("latest_offer_creator")]
        public string LatestOfferCreator { get; set; }

        [JsonPropertyName("counter_limit")]
        public object CounterLimit { get; set; }

        [JsonPropertyName("offer_due_date")]
        public object OfferDueDate { get; set; }
    }

    public partial class ReturnPickupAddress
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("town")]
        public string Town { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("zipcode")]
        public string Zipcode { get; set; }
    }

    public partial class SellerCompensation
    {
        [JsonPropertyName("seller_compensation_status")]
        public string SellerCompensationStatus { get; set; }

        [JsonPropertyName("seller_compensation_due_date")]
        public object SellerCompensationDueDate { get; set; }

        [JsonPropertyName("compensation_amount")]
        public object CompensationAmount { get; set; }
    }

    public partial class SellerProof
    {
        [JsonPropertyName("seller_proof_status")]
        public string SellerProofStatus { get; set; }

        [JsonPropertyName("seller_evidence_deadline")]
        public object SellerEvidenceDeadline { get; set; }
    }
}
