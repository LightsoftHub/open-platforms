using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Product
{
    public class UpdateStockResponse
    {
        [JsonPropertyName("failure_list")]
        public List<UpdateStockFailureList> FailureList { get; set; }

        [JsonPropertyName("success_list")]
        public List<UpdateStockSuccessListDto> SuccessList { get; set; }
    }

    public class UpdateStockSuccessListDto
    {
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("normal_stock")]
        public int NormalStock { get; set; }
    }

    public class UpdateStockFailureList
    {
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        [JsonPropertyName("failed_reason")]
        public string FailedReason { get; set; }
    }
}
