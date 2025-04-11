using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models.Orders
{
    public class Order
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("fulfillment_type")]
        public string FulfillmentType { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("status_histories")]
        public List<StatusHistory> StatusHistories { get; set; }

        [JsonPropertyName("is_virtual")]
        public bool IsVirtual { get; set; }

        [JsonPropertyName("siblings")]
        public List<object> Siblings { get; set; }

        [JsonPropertyName("tikixu_point_earning")]
        public long TikixuPointEarning { get; set; }

        [JsonPropertyName("is_flower_gift")]
        public bool IsFlowerGift { get; set; }

        [JsonPropertyName("dropship_already")]
        public bool DropshipAlready { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("shipment_status_histories")]
        public List<object> ShipmentStatusHistories { get; set; }

        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        [JsonPropertyName("main_substate_text_en")]
        public string MainSubstateTextEn { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("state_histories")]
        public List<object> StateHistories { get; set; }

        [JsonPropertyName("inventory_status")]
        public string InventoryStatus { get; set; }

        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("seller_warehouse")]
        public SellerWarehouse SellerWarehouse { get; set; }

        [JsonPropertyName("linked_code")]
        public string LinkedCode { get; set; }

        [JsonPropertyName("has_backorder_items")]
        public bool HasBackorderItems { get; set; }

        [JsonPropertyName("multiseller_confirmation")]
        public MultisellerConfirmation MultisellerConfirmation { get; set; }

        [JsonPropertyName("original_code")]
        public string OriginalCode { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        [JsonPropertyName("children")]
        public List<object> Children { get; set; }

        [JsonPropertyName("shipment_mappings")]
        public List<object> ShipmentMappings { get; set; }

        [JsonPropertyName("backend_id")]
        public long? BackendId { get; set; }

        [JsonPropertyName("main_substate")]
        public string MainSubstate { get; set; }

        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }

        [JsonPropertyName("is_bookcare")]
        public bool IsBookcare { get; set; }

        [JsonPropertyName("relation_code")]
        public string RelationCode { get; set; }

        [JsonPropertyName("is_rma")]
        public bool IsRma { get; set; }

        [JsonPropertyName("cancel_info")]
        public CancelInfo CancelInfo { get; set; }

        [JsonPropertyName("boxes")]
        public List<object> Boxes { get; set; }

        [JsonPropertyName("delivery")]
        public Delivery Delivery { get; set; }

        [JsonPropertyName("main_state")]
        public string MainState { get; set; }

        [JsonPropertyName("tiki_warehouse")]
        public TikiWarehouse TikiWarehouse { get; set; }

        [JsonPropertyName("labels")]
        public List<object> Labels { get; set; }

        [JsonPropertyName("applied_rule_ids")]
        public List<object> AppliedRuleIds { get; set; }

        [JsonPropertyName("is_vat_exporting")]
        public bool IsVatExporting { get; set; }

        [JsonPropertyName("main_state_text")]
        public string MainStateText { get; set; }

        [JsonPropertyName("main_substate_text")]
        public string MainSubstateText { get; set; }

        [JsonPropertyName("invoice")]
        public Invoice Invoice { get; set; }

        [JsonPropertyName("main_state_text_en")]
        public string MainStateTextEn { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("ward")]
        public string Ward { get; set; }

        [JsonPropertyName("ward_tiki_code")]
        public string WardTikiCode { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("district_tiki_code")]
        public string DistrictTikiCode { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("region_tiki_code")]
        public string RegionTikiCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_id")]
        public string CountryId { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }

    public class BillingAddress
    {
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("ward")]
        public string Ward { get; set; }

        [JsonPropertyName("ward_tiki_code")]
        public string WardTikiCode { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("district_tiki_code")]
        public string DistrictTikiCode { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("region_tiki_code")]
        public string RegionTikiCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_id")]
        public string CountryId { get; set; }
    }

    public class Customer
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }

    public class Delivery
    {
        [JsonPropertyName("delivery_confirmed")]
        public bool DeliveryConfirmed { get; set; }

        [JsonPropertyName("delivery_confirmed_at")]
        public object DeliveryConfirmedAt { get; set; }

        [JsonPropertyName("delivery_confirmed_by_customer")]
        public bool DeliveryConfirmedByCustomer { get; set; }

        [JsonPropertyName("delivery_confirmed_by_customer_at")]
        public object DeliveryConfirmedByCustomerAt { get; set; }

        [JsonPropertyName("delivery_note")]
        public object DeliveryNote { get; set; }

        [JsonPropertyName("delivery_confirmation")]
        public List<object> DeliveryConfirmation { get; set; }
    }

    public class Invoice
    {
        [JsonPropertyName("items_count")]
        public int ItemsCount { get; set; }

        [JsonPropertyName("items_quantity")]
        public int ItemsQuantity { get; set; }

        [JsonPropertyName("subtotal")]
        public decimal Subtotal { get; set; }

        [JsonPropertyName("grand_total")]
        public decimal GrandTotal { get; set; }

        [JsonPropertyName("collectible_amount")]
        public decimal CollectibleAmount { get; set; }

        [JsonPropertyName("discount_amount")]
        public decimal DiscountAmount { get; set; }

        [JsonPropertyName("discount_tikixu")]
        public decimal DiscountTikixu { get; set; }

        [JsonPropertyName("discount_promotion")]
        public decimal DiscountPromotion { get; set; }

        [JsonPropertyName("discount_percent")]
        public int DiscountPercent { get; set; }

        [JsonPropertyName("discount_coupon")]
        public decimal DiscountCoupon { get; set; }

        [JsonPropertyName("discount_other")]
        public decimal DiscountOther { get; set; }

        [JsonPropertyName("gift_card_amount")]
        public decimal GiftCardAmount { get; set; }

        [JsonPropertyName("gift_card_code")]
        public string GiftCardCode { get; set; }

        [JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; }

        [JsonPropertyName("shipping_amount_after_discount")]
        public decimal ShippingAmountAfterDiscount { get; set; }

        [JsonPropertyName("shipping_discount_amount")]
        public decimal ShippingDiscountAmount { get; set; }

        [JsonPropertyName("handling_fee")]
        public decimal HandlingFee { get; set; }

        [JsonPropertyName("other_fee")]
        public decimal OtherFee { get; set; }

        [JsonPropertyName("total_seller_fee")]
        public decimal TotalSellerFee { get; set; }

        [JsonPropertyName("total_seller_income")]
        public decimal TotalSellerIncome { get; set; }

        [JsonPropertyName("purchased_at")]
        public string PurchasedAt { get; set; }

        [JsonPropertyName("tax_info")]
        public object TaxInfo { get; set; }
    }

    public class MultisellerConfirmation
    {
        [JsonPropertyName("seller_id")]
        public long SellerId { get; set; }

        [JsonPropertyName("need_other_sellers_confirm")]
        public bool NeedOtherSellersConfirm { get; set; }
    }

    public class Payment
    {
        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("is_prepaid")]
        public bool IsPrepaid { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Plan
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_free_shipping")]
        public bool IsFreeShipping { get; set; }

        [JsonPropertyName("promised_delivery_date")]
        public string PromisedDeliveryDate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class SellerWarehouse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonPropertyName("street")]
        public string Street { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("warehouse_type")]
        public string WarehouseType { get; set; }

        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }

        [JsonPropertyName("region_id")]
        public long RegionId { get; set; }

        [JsonPropertyName("region_name")]
        public string RegionName { get; set; }

        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        [JsonPropertyName("district_id")]
        public long DistrictId { get; set; }

        [JsonPropertyName("district_name")]
        public string DistrictName { get; set; }

        [JsonPropertyName("ward_code")]
        public string WardCode { get; set; }

        [JsonPropertyName("ward_id")]
        public long WardId { get; set; }

        [JsonPropertyName("ward_name")]
        public string WardName { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }
    }

    public class Shipping
    {
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        [JsonPropertyName("partner_name")]
        public string PartnerName { get; set; }

        [JsonPropertyName("tracking_code")]
        public string TrackingCode { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("pickup_shipping_code")]
        public string PickupShippingCode { get; set; }

        [JsonPropertyName("pickup_partner_code")]
        public string PickupPartnerCode { get; set; }

        [JsonPropertyName("return_shipping_code")]
        public string ReturnShippingCode { get; set; }

        [JsonPropertyName("return_partner_code")]
        public string ReturnPartnerCode { get; set; }

        [JsonPropertyName("delivery_shipping_code")]
        public string DeliveryShippingCode { get; set; }

        [JsonPropertyName("delivery_partner_code")]
        public string DeliveryPartnerCode { get; set; }

        [JsonPropertyName("plan")]
        public Plan Plan { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("shipping_detail")]
        public object ShippingDetail { get; set; }
    }

    public class StatusHistory
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TikiWarehouse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    public class CancelInfo
    {
        [JsonPropertyName("reason_code")]
        public string ReasonCode { get; set; }

        [JsonPropertyName("reason_text")]
        public string ReasonText { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("canceled_at")]
        public object CanceledAt { get; set; }
    }
}