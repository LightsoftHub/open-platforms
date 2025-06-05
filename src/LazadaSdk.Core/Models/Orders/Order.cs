using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Orders
{
    public class Order
    {
        [JsonPropertyName("voucher")]
        public decimal Voucher { get; set; }

        [JsonPropertyName("warehouse_code")]
        public string WarehouseCode { get; set; }

        [JsonPropertyName("order_number")]
        public long OrderNumber { get; set; }

        [JsonPropertyName("voucher_seller")]
        public decimal VoucherSeller { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }

        [JsonPropertyName("gift_option")]
        public bool GiftOption { get; set; }

        [JsonPropertyName("shipping_fee_discount_platform")]
        public double ShippingFeeDiscountPlatform { get; set; }

        [JsonPropertyName("customer_last_name")]
        public string CustomerLastName { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("promised_shipping_times")]
        public string PromisedShippingTimes { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("national_registration_number")]
        public string NationalRegistrationNumber { get; set; }

        [JsonPropertyName("shipping_fee_original")]
        public decimal ShippingFeeOriginal { get; set; }

        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("customer_first_name")]
        public string CustomerFirstName { get; set; }

        [JsonPropertyName("shipping_fee_discount_seller")]
        public double ShippingFeeDiscountSeller { get; set; }

        [JsonPropertyName("shipping_fee")]
        public decimal ShippingFee { get; set; }

        [JsonPropertyName("branch_number")]
        public string BranchNumber { get; set; }

        [JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }

        [JsonPropertyName("items_count")]
        public int ItemsCount { get; set; }

        [JsonPropertyName("delivery_info")]
        public string DeliveryInfo { get; set; }

        [JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }

        [JsonPropertyName("address_billing")]
        public AddressBilling AddressBilling { get; set; }

        [JsonPropertyName("extra_attributes")]
        public string ExtraAttributes { get; set; }

        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        [JsonPropertyName("gift_message")]
        public string GiftMessage { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("address_shipping")]
        public AddressShipping AddressShipping { get; set; }
    }

    public class AddressBilling
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("address3")]
        public string Address3 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("post_code")]
        public string PostCode { get; set; }

        [JsonPropertyName("phone2")]
        public string Phone2 { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("address5")]
        public string Address5 { get; set; }

        [JsonPropertyName("address4")]
        public string Address4 { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
    }

    public class AddressShipping
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("address3")]
        public string Address3 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("post_code")]
        public string PostCode { get; set; }

        [JsonPropertyName("phone2")]
        public string Phone2 { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("address5")]
        public string Address5 { get; set; }

        [JsonPropertyName("address4")]
        public string Address4 { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
    }
}
