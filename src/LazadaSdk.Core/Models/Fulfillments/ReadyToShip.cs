using Light.Lazada.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Fulfillments
{
    public class ReadyToShipResult
    {
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        [JsonPropertyName("data")]
        public ReadyToShipData Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        public LazResponse Result
        {
            get
            {
                if (Success)
                    return LazResponse.Success();
                else
                    return LazResponse.Failed(ErrorMsg, ErrorCode);
            }
        }
    }

    public class ReadyToShipData
    {
        [JsonPropertyName("packages")]
        public List<ReadyToShipPackage> Packages { get; set; }
    }

    public class ReadyToShipPackage
    {
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        [JsonPropertyName("item_err_code")]
        public string ItemErrCode { get; set; }

        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }

        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
