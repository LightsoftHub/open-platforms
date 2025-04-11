using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Orders
{
    public class OrderItem
    {
        [JsonPropertyName("pick_up_store_info")]
        public PickUpStoreInfo PickUpStoreInfo { get; set; }

        [JsonPropertyName("tax_amount")]
        public decimal TaxAmount { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("sla_time_stamp")]
        public string SlaTimeStamp { get; set; }

        [JsonPropertyName("voucher_seller")]
        public decimal VoucherSeller { get; set; }

        [JsonPropertyName("purchase_order_id")]
        public string PurchaseOrderId { get; set; }

        [JsonPropertyName("voucher_code_seller")]
        public string VoucherCodeSeller { get; set; }

        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }

        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }

        [JsonPropertyName("buyer_id")]
        public object BuyerId { get; set; }

        [JsonPropertyName("variation")]
        public string Variation { get; set; }

        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        [JsonPropertyName("voucher_code_platform")]
        public string VoucherCodePlatform { get; set; }

        [JsonPropertyName("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("cancel_return_initiator")]
        public string CancelReturnInitiator { get; set; }

        [JsonPropertyName("shop_sku")]
        public string ShopSku { get; set; }

        [JsonPropertyName("is_reroute")]
        public int IsReroute { get; set; }

        [JsonPropertyName("stage_pay_status")]
        public string StagePayStatus { get; set; }

        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        [JsonPropertyName("tracking_code_pre")]
        public string TrackingCodePre { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        [JsonPropertyName("order_flag")]
        public string OrderFlag { get; set; }

        [JsonPropertyName("is_fbl")]
        public int IsFbl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("delivery_option_sof")]
        public int DeliveryOptionSof { get; set; }

        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("product_main_image")]
        public string ProductMainImage { get; set; }

        [JsonPropertyName("voucher_platform")]
        public decimal VoucherPlatform { get; set; }

        [JsonPropertyName("paid_price")]
        public decimal PaidPrice { get; set; }

        [JsonPropertyName("product_detail_url")]
        public string ProductDetailUrl { get; set; }

        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }

        [JsonPropertyName("promised_shipping_time")]
        public string PromisedShippingTime { get; set; }

        [JsonPropertyName("shipping_type")]
        public string ShippingType { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("voucher_seller_lpi")]
        public decimal VoucherSellerLpi { get; set; }

        [JsonPropertyName("shipping_fee_discount_platform")]
        public decimal ShippingFeeDiscountPlatform { get; set; }

        [JsonPropertyName("wallet_credits")]
        public int WalletCredits { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("shipping_provider_type")]
        public string ShippingProviderType { get; set; }

        [JsonPropertyName("voucher_platform_lpi")]
        public decimal VoucherPlatformLpi { get; set; }

        [JsonPropertyName("shipping_fee_original")]
        public decimal ShippingFeeOriginal { get; set; }

        [JsonPropertyName("item_price")]
        public decimal ItemPrice { get; set; }

        [JsonPropertyName("is_digital")]
        public int IsDigital { get; set; }

        [JsonPropertyName("shipping_service_cost")]
        public int ShippingServiceCost { get; set; }

        [JsonPropertyName("tracking_code")]
        public string TrackingCode { get; set; }

        [JsonPropertyName("shipping_fee_discount_seller")]
        public decimal ShippingFeeDiscountSeller { get; set; }

        [JsonPropertyName("shipping_amount")]
        public decimal ShippingAmount { get; set; }

        [JsonPropertyName("reason_detail")]
        public string ReasonDetail { get; set; }

        [JsonPropertyName("return_status")]
        public string ReturnStatus { get; set; }

        [JsonPropertyName("shipment_provider")]
        public string ShipmentProvider { get; set; }

        [JsonPropertyName("voucher_amount")]
        public decimal VoucherAmount { get; set; }

        [JsonPropertyName("digital_delivery_info")]
        public string DigitalDeliveryInfo { get; set; }

        [JsonPropertyName("extra_attributes")]
        public string ExtraAttributes { get; set; }
    }

    public class PickUpStoreInfo
    {
    }
}
