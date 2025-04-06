using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Returns
{
    public class ReturnListResponse
    {
        [JsonPropertyName("more")]
        public bool More { get; set; }

        [JsonPropertyName("return")]
        public List<Return> Return { get; set; }
    }

    public class Return
    {
        [JsonPropertyName("image")]
        public List<string> Image { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("text_reason")]
        public string TextReason { get; set; }

        [JsonPropertyName("return_sn")]
        public string ReturnSn { get; set; }

        [JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

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
        public int AmountBeforeDiscount { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("item")]
        public List<Item> Item { get; set; }

        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("return_ship_due_date")]
        public int ReturnShipDueDate { get; set; }

        [JsonPropertyName("return_seller_due_date")]
        public int ReturnSellerDueDate { get; set; }

        [JsonPropertyName("negotiation_status")]
        public string NegotiationStatus { get; set; }

        [JsonPropertyName("seller_proof_status")]
        public string SellerProofStatus { get; set; }

        [JsonPropertyName("seller_compensation_status")]
        public string SellerCompensationStatus { get; set; }
    }
}
