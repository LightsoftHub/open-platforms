using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Payment
{
    public partial class EscrowDetailResponse
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("buyer_user_name")]
        public string BuyerUserName { get; set; }

        [JsonPropertyName("return_order_sn_list")]
        public List<object> ReturnOrderSnList { get; set; }

        [JsonPropertyName("order_income")]
        public OrderIncome OrderIncome { get; set; }
    }

    public partial class OrderIncome
    {
        [JsonPropertyName("escrow_amount")]
        public long EscrowAmount { get; set; }

        [JsonPropertyName("buyer_total_amount")]
        public long BuyerTotalAmount { get; set; }

        [JsonPropertyName("original_price")]
        public long OriginalPrice { get; set; }

        [JsonPropertyName("seller_discount")]
        public long SellerDiscount { get; set; }

        [JsonPropertyName("shopee_discount")]
        public long ShopeeDiscount { get; set; }

        [JsonPropertyName("voucher_from_seller")]
        public long VoucherFromSeller { get; set; }

        [JsonPropertyName("voucher_from_shopee")]
        public long VoucherFromShopee { get; set; }

        [JsonPropertyName("coins")]
        public double Coins { get; set; }

        [JsonPropertyName("buyer_paid_shipping_fee")]
        public long BuyerPaidShippingFee { get; set; }

        [JsonPropertyName("buyer_transaction_fee")]
        public long BuyerTransactionFee { get; set; }

        [JsonPropertyName("cross_border_tax")]
        public long CrossBorderTax { get; set; }

        [JsonPropertyName("payment_promotion")]
        public long PaymentPromotion { get; set; }

        [JsonPropertyName("commission_fee")]
        public long CommissionFee { get; set; }

        [JsonPropertyName("service_fee")]
        public long ServiceFee { get; set; }

        [JsonPropertyName("seller_transaction_fee")]
        public long SellerTransactionFee { get; set; }

        [JsonPropertyName("seller_lost_compensation")]
        public long SellerLostCompensation { get; set; }

        [JsonPropertyName("seller_coin_cash_back")]
        public long SellerCoinCashBack { get; set; }

        [JsonPropertyName("escrow_tax")]
        public long EscrowTax { get; set; }

        [JsonPropertyName("final_shipping_fee")]
        public long FinalShippingFee { get; set; }

        [JsonPropertyName("actual_shipping_fee")]
        public long ActualShippingFee { get; set; }

        [JsonPropertyName("order_chargeable_weight")]
        public long OrderChargeableWeight { get; set; }

        [JsonPropertyName("shopee_shipping_rebate")]
        public long ShopeeShippingRebate { get; set; }

        [JsonPropertyName("shipping_fee_discount_from_3pl")]
        public long ShippingFeeDiscountFrom3Pl { get; set; }

        [JsonPropertyName("seller_shipping_discount")]
        public long SellerShippingDiscount { get; set; }

        [JsonPropertyName("estimated_shipping_fee")]
        public long EstimatedShippingFee { get; set; }

        [JsonPropertyName("seller_voucher_code")]
        public List<string> SellerVoucherCode { get; set; }

        [JsonPropertyName("drc_adjustable_refund")]
        public long DrcAdjustableRefund { get; set; }

        [JsonPropertyName("cost_of_goods_sold")]
        public long CostOfGoodsSold { get; set; }

        [JsonPropertyName("original_cost_of_goods_sold")]
        public long OriginalCostOfGoodsSold { get; set; }

        [JsonPropertyName("original_shopee_discount")]
        public long OriginalShopeeDiscount { get; set; }

        [JsonPropertyName("seller_return_refund")]
        public long SellerReturnRefund { get; set; }

        [JsonPropertyName("refund_amount_to_buyer")]
        public long RefundAmountToBuyer { get; set; }

        [JsonPropertyName("reverse_shipping_fee")]
        public long ReverseShippingFee { get; set; }

        [JsonPropertyName("final_product_protection")]
        public long FinalProductProtection { get; set; }

        [JsonPropertyName("credit_card_promotion")]
        public double CreditCardPromotion { get; set; }

        [JsonPropertyName("credit_card_transaction_fee")]
        public long CreditCardTransactionFee { get; set; }

        [JsonPropertyName("final_product_vat_tax")]
        public long FinalProductVatTax { get; set; }

        [JsonPropertyName("final_shipping_vat_tax")]
        public long FinalShippingVatTax { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("item_id")]
        public long ItemId { get; set; }

        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        [JsonPropertyName("item_sku")]
        public string ItemSku { get; set; }

        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        [JsonPropertyName("model_sku")]
        public string ModelSku { get; set; }

        [JsonPropertyName("original_price")]
        public long OriginalPrice { get; set; }

        [JsonPropertyName("shopee_discount")]
        public long ShopeeDiscount { get; set; }

        [JsonPropertyName("seller_discount")]
        public long SellerDiscount { get; set; }

        [JsonPropertyName("discounted_price")]
        public double DiscountedPrice { get; set; }

        [JsonPropertyName("discount_from_coin")]
        public long DiscountFromCoin { get; set; }

        [JsonPropertyName("discount_from_voucher_shopee")]
        public long DiscountFromVoucherShopee { get; set; }

        [JsonPropertyName("discount_from_voucher_seller")]
        public double DiscountFromVoucherSeller { get; set; }

        [JsonPropertyName("activity_type")]
        public string ActivityType { get; set; }

        [JsonPropertyName("is_main_item")]
        public bool IsMainItem { get; set; }

        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }

        [JsonPropertyName("quantity_purchased")]
        public int QuantityPurchased { get; set; }
    }
}
