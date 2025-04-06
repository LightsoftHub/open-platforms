using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Order
{
    public class OrdersDetailsResponse
    {
        [JsonPropertyName("order_list")]
        public List<OrderDetail> OrderDetail { get; set; }
    }

    public class ImageInfo
    {
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ItemList
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

        [JsonPropertyName("model_quantity_purchased")]
        public int ModelQuantityPurchased { get; set; }

        [JsonPropertyName("model_original_price")]
        public int ModelOriginalPrice { get; set; }

        [JsonPropertyName("model_discounted_price")]
        public int ModelDiscountedPrice { get; set; }

        [JsonPropertyName("wholesale")]
        public bool Wholesale { get; set; }

        [JsonPropertyName("weight")]
        public double Weight { get; set; }

        [JsonPropertyName("add_on_deal")]
        public bool AddOnDeal { get; set; }

        [JsonPropertyName("main_item")]
        public bool MainItem { get; set; }

        [JsonPropertyName("add_on_deal_id")]
        public long AddOnDealId { get; set; }

        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }

        [JsonPropertyName("promotion_id")]
        public long PromotionId { get; set; }

        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("promotion_group_id")]
        public long PromotionGroupId { get; set; }

        [JsonPropertyName("image_info")]
        public ImageInfo ImageInfo { get; set; }

        [JsonPropertyName("product_location_id")]
        public List<string> ProductLocationId { get; set; }

        [JsonPropertyName("is_prescription_item")]
        public bool IsPrescriptionItem { get; set; }
    }

    public class OrderDetail
    {
        [JsonPropertyName("actual_shipping_fee")]
        public double ActualShippingFee { get; set; }

        [JsonPropertyName("actual_shipping_fee_confirmed")]
        public bool ActualShippingFeeConfirmed { get; set; }

        [JsonPropertyName("buyer_cancel_reason")]
        public string BuyerCancelReason { get; set; }

        [JsonPropertyName("buyer_cpf_id")]
        public object BuyerCpfId { get; set; }

        [JsonPropertyName("buyer_user_id")]
        public long? BuyerUserId { get; set; }

        [JsonPropertyName("buyer_username")]
        public string BuyerUsername { get; set; }

        [JsonPropertyName("cancel_by")]
        public string CancelBy { get; set; }

        [JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonPropertyName("checkout_shipping_carrier")]
        public string CheckoutShippingCarrier { get; set; }

        [JsonPropertyName("cod")]
        public bool Cod { get; set; }

        [JsonPropertyName("create_time")]
        public int CreateTime { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("days_to_ship")]
        public int DaysToShip { get; set; }

        [JsonPropertyName("dropshipper")]
        public string Dropshipper { get; set; }

        [JsonPropertyName("dropshipper_phone")]
        public string DropshipperPhone { get; set; }

        [JsonPropertyName("fulfillment_flag")]
        public string FulfillmentFlag { get; set; }

        [JsonPropertyName("goods_to_declare")]
        public bool GoodsToDeclare { get; set; }

        [JsonPropertyName("invoice_data")]
        public object InvoiceData { get; set; }

        [JsonPropertyName("item_list")]
        public List<ItemList> ItemList { get; set; }

        [JsonPropertyName("message_to_seller")]
        public string MessageToSeller { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("note_update_time")]
        public int NoteUpdateTime { get; set; }

        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        //[JsonPropertyName("package_list")]
        //public List<PackageList> PackageList { get; set; }

        [JsonPropertyName("pay_time")]
        public int? PayTime { get; set; }

        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("pickup_done_time")]
        public int PickupDoneTime { get; set; }

        [JsonPropertyName("prescription_check_status")]
        public object PrescriptionCheckStatus { get; set; }

        [JsonPropertyName("recipient_address")]
        public RecipientAddress RecipientAddress { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("reverse_shipping_fee")]
        public double ReverseShippingFee { get; set; }

        [JsonPropertyName("ship_by_date")]
        public int ShipByDate { get; set; }

        [JsonPropertyName("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonPropertyName("split_up")]
        public bool SplitUp { get; set; }

        [JsonPropertyName("total_amount")]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }
    }

    public class PackageList
    {
        [JsonPropertyName("package_number")]
        public string PackageNumber { get; set; }

        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }

        [JsonPropertyName("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonPropertyName("parcel_chargeable_weight_gram")]
        public int ParcelChargeableWeightGram { get; set; }

        [JsonPropertyName("item_list")]
        public List<ItemList> ItemList { get; set; }
    }

    public class RecipientAddress
    {
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

        [JsonPropertyName("full_address")]
        public string FullAddress { get; set; }
    }
}

