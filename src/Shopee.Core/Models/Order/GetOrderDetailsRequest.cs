using Light.Shopee.Extensions;

namespace Light.Shopee.Models.Order
{
    public class GetOrderDetailsRequest : BaseRequest
    {
        public GetOrderDetailsRequest(string[] order_sn_list)
        {
            Add("order_sn_list", order_sn_list.JoinToString());
            Add("response_optional_fields", orderResponseFields.JoinToString());
        }

        private static string[] orderResponseFields => new string[]
        {
            "buyer_user_id",
            "buyer_username",
            "recipient_address",
            "actual_shipping_fee",
            "goods_to_declare",
            "note",
            "note_update_time",
            "item_list",
            "pay_time",
            "dropshipper",
            "dropshipper_phone",
            "split_up",
            "buyer_cancel_reason",
            "cancel_by",
            "cancel_reason",
            "actual_shipping_fee_confirmed",
            "buyer_cpf_id",
            "fulfillment_flag",
            "pickup_done_time",
            "package_list",
            "shipping_carrier",
            "payment_method",
            "total_amount",
            "buyer_username",
            "invoice_data",
            "checkout_shipping_carrier",
            "reverse_shipping_fee",
        };
    }
}
