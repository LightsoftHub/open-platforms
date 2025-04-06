using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Order
{
    public class HandleBuyerCancellationResponse
    {
        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }
    }
}