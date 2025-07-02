using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Order
{
    public class BuyerInvoiceInfoResponse : ShopeeResult, IShopeeResult<List<BuyerInvoiceInfo>>
    {
        [JsonPropertyName("invoice_info_list")]
        public List<BuyerInvoiceInfo> Response { get; set; }

        public override bool Succeeded => base.Succeeded && Response != null;
    }

    public class BuyerInvoiceInfo
    {
        [JsonPropertyName("order_sn")]
        public string OrderSn { get; set; }

        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        [JsonPropertyName("is_requested")]
        public bool IsRequested { get; set; }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("invoice_detail")]
        public object InvoiceDetail { get; set; }
    }
}
