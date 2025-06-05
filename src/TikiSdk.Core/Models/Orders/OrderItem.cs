using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Orders
{

    public class Item
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("seller")]
        public Seller Seller { get; set; }

        [JsonPropertyName("confirmation")]
        public Confirmation Confirmation { get; set; }

        [JsonPropertyName("parent_item_id")]
        public long ParentItemId { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("qty")]
        public int Qty { get; set; }

        [JsonPropertyName("fulfilled_at")]
        public object FulfilledAt { get; set; }

        [JsonPropertyName("is_virtual")]
        public bool IsVirtual { get; set; }

        [JsonPropertyName("is_ebook")]
        public bool IsEbook { get; set; }

        [JsonPropertyName("is_bookcare")]
        public bool IsBookcare { get; set; }

        [JsonPropertyName("is_free_gift")]
        public bool IsFreeGift { get; set; }

        [JsonPropertyName("is_fulfilled")]
        public bool IsFulfilled { get; set; }

        [JsonPropertyName("backend_id")]
        public long? BackendId { get; set; }

        [JsonPropertyName("applied_rule_ids")]
        public List<object> AppliedRuleIds { get; set; }

        [JsonPropertyName("invoice")]
        public ItemInvoice Invoice { get; set; }

        [JsonPropertyName("inventory_requisition")]
        public object InventoryRequisition { get; set; }

        [JsonPropertyName("inventory_withdrawals")]
        public List<object> InventoryWithdrawals { get; set; }

        [JsonPropertyName("seller_inventory_id")]
        public long SellerInventoryId { get; set; }

        [JsonPropertyName("seller_inventory_name")]
        public string SellerInventoryName { get; set; }

        [JsonPropertyName("seller_income_detail")]
        public SellerIncomeDetail SellerIncomeDetail { get; set; }
    }

    public class Confirmation
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonPropertyName("available_confirm_sla")]
        public string AvailableConfirmSla { get; set; }

        [JsonPropertyName("pickup_confirm_sla")]
        public object PickupConfirmSla { get; set; }

        [JsonPropertyName("histories")]
        public List<History> Histories { get; set; }
    }

    public class Discount
    {
        [JsonPropertyName("discount_shipping_fee")]
        public DiscountShippingFee DiscountShippingFee { get; set; }

        [JsonPropertyName("discount_coupon")]
        public DiscountCoupon DiscountCoupon { get; set; }

        [JsonPropertyName("discount_tikixu")]
        public DiscountTikixu DiscountTikixu { get; set; }
    }

    public class DiscountCoupon
    {
        [JsonPropertyName("seller_discount")]
        public decimal SellerDiscount { get; set; }

        [JsonPropertyName("platform_discount")]
        public decimal PlatformDiscount { get; set; }

        [JsonPropertyName("total_discount")]
        public decimal TotalDiscount { get; set; }
    }

    public class DiscountData
    {
    }

    public class DiscountShippingFee
    {
        [JsonPropertyName("sellerDiscount")]
        public decimal SellerDiscount { get; set; }

        [JsonPropertyName("fee_amount")]
        public decimal FeeAmount { get; set; }

        [JsonPropertyName("qty")]
        public int Qty { get; set; }

        [JsonPropertyName("apply_discount")]
        public List<object> ApplyDiscount { get; set; }

        [JsonPropertyName("seller_subsidy")]
        public decimal SellerSubsidy { get; set; }

        [JsonPropertyName("tiki_subsidy")]
        public decimal TikiSubsidy { get; set; }
    }

    public class DiscountTikixu
    {
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
    }

    public class Fee
    {
        [JsonPropertyName("id")]
        public object Id { get; set; }

        [JsonPropertyName("fee_type_key")]
        public string FeeTypeKey { get; set; }

        [JsonPropertyName("fee_type_name")]
        public string FeeTypeName { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("quantity")]
        public object Quantity { get; set; }

        [JsonPropertyName("base_amount")]
        public decimal BaseAmount { get; set; }

        [JsonPropertyName("total_amount")]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("discount_amount")]
        public decimal DiscountAmount { get; set; }

        [JsonPropertyName("final_amount")]
        public decimal FinalAmount { get; set; }
    }

    public class History
    {
        [JsonPropertyName("confirmed_at")]
        public object ConfirmedAt { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("sla_confirmed_at")]
        public string SlaConfirmedAt { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class ItemInvoice
    {
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("subtotal")]
        public decimal Subtotal { get; set; }

        [JsonPropertyName("row_total")]
        public decimal RowTotal { get; set; }

        [JsonPropertyName("discount_amount")]
        public decimal DiscountAmount { get; set; }

        [JsonPropertyName("discount_tikixu")]
        public decimal DiscountTikixu { get; set; }

        [JsonPropertyName("discount_promotion")]
        public decimal DiscountPromotion { get; set; }

        [JsonPropertyName("discount_percent")]
        public decimal DiscountPercent { get; set; }

        [JsonPropertyName("discount_coupon")]
        public decimal DiscountCoupon { get; set; }

        [JsonPropertyName("discount_other")]
        public decimal DiscountOther { get; set; }

        [JsonPropertyName("discount_tikier")]
        public decimal DiscountTikier { get; set; }

        [JsonPropertyName("discount_tiki_first")]
        public decimal DiscountTikiFirst { get; set; }

        [JsonPropertyName("discount_data")]
        public IDictionary<string, decimal> DiscountData { get; set; }

        [JsonPropertyName("is_seller_discount_coupon")]
        public bool IsSellerDiscountCoupon { get; set; }

        [JsonPropertyName("is_taxable")]
        public bool IsTaxable { get; set; }

        [JsonPropertyName("fob_price")]
        public decimal FobPrice { get; set; }

        [JsonPropertyName("seller_fee")]
        public decimal SellerFee { get; set; }

        [JsonPropertyName("seller_income")]
        public decimal SellerIncome { get; set; }

        [JsonPropertyName("fees")]
        public List<Fee> Fees { get; set; }
    }

    public class Product
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("super_id")]
        public long SuperId { get; set; }

        [JsonPropertyName("master_id")]
        public long MasterId { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("catalog_group_name")]
        public string CatalogGroupName { get; set; }

        [JsonPropertyName("inventory_type")]
        public string InventoryType { get; set; }

        [JsonPropertyName("imeis")]
        public List<object> Imeis { get; set; }

        [JsonPropertyName("serial_numbers")]
        public List<object> SerialNumbers { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("seller_product_code")]
        public string SellerProductCode { get; set; }

        [JsonPropertyName("seller_supply_method")]
        public object SellerSupplyMethod { get; set; }
    }

    public class Seller
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class SellerFee
    {
        [JsonPropertyName("id")]
        public object Id { get; set; }

        [JsonPropertyName("fee_type_key")]
        public string FeeTypeKey { get; set; }

        [JsonPropertyName("fee_type_name")]
        public string FeeTypeName { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("quantity")]
        public object Quantity { get; set; }

        [JsonPropertyName("base_amount")]
        public decimal BaseAmount { get; set; }

        [JsonPropertyName("total_amount")]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("discount_amount")]
        public decimal DiscountAmount { get; set; }

        [JsonPropertyName("final_amount")]
        public decimal FinalAmount { get; set; }
    }

    public class SellerIncomeDetail
    {
        [JsonPropertyName("item_price")]
        public decimal ItemPrice { get; set; }

        [JsonPropertyName("item_qty")]
        public int ItemQty { get; set; }

        [JsonPropertyName("shipping_fee")]
        public decimal ShippingFee { get; set; }

        [JsonPropertyName("seller_fees")]
        public List<SellerFee> SellerFees { get; set; }

        [JsonPropertyName("sub_total")]
        public decimal SubTotal { get; set; }

        [JsonPropertyName("seller_income")]
        public decimal SellerIncome { get; set; }

        [JsonPropertyName("discount")]
        public Discount Discount { get; set; }
    }
}