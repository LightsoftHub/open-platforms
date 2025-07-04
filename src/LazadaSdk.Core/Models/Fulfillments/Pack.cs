using Light.Lazada.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Fulfillments
{
    public class PackResult
    {
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Read PackedID from response data
        /// </summary>
        /// <returns></returns>
        public ILazResponse<string[]> Packages
        {
            get
            {
                var errors = Data?.PackOrderList
                    .FirstOrDefault()?.OrderItemList // select order item list by Order ID
                    .Where(x => x.ItemErrCode != "0") // success code == 0, if any error will difference 0 value
                    .Select(s => $"{s.ItemErrCode} - {s.Msg}")
                    .Distinct();

                if (errors != null && errors.Any())
                    return LazResult<string[]>.Failed(string.Join(",", errors));

                var packageIds = Data?.PackOrderList?[0].OrderItemList?
                    .Select(s => s.PackageId).ToArray();

                if (packageIds != null && packageIds.Length > 0)
                {
                    return LazResult<string[]>.Success(packageIds);
                }

                return LazResult<string[]>.Failed(ErrorMsg, ErrorCode);
            }
        }
    }

    public class Data
    {
        [JsonPropertyName("pack_order_list")]
        public List<PackOrderList> PackOrderList { get; set; }
    }

    public class OrderItemList
    {
        [JsonPropertyName("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        [JsonPropertyName("item_err_code")]
        public string ItemErrCode { get; set; }

        [JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonPropertyName("shipment_provider")]
        public string ShipmentProvider { get; set; }

        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }

        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }

    public class PackOrderList
    {
        [JsonPropertyName("order_item_list")]
        public List<OrderItemList> OrderItemList { get; set; }

        [JsonPropertyName("order_id")]
        public long OrderId { get; set; }
    }
}