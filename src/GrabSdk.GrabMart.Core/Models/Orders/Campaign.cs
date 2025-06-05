using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class Campaign
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public string Level { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("usageCount")]
        public int UsageCount { get; set; }

        [JsonPropertyName("mexFundedRatio")]
        public decimal MexFundedRatio { get; set; }

        [JsonPropertyName("deductedAmount")]
        public decimal DeductedAmount { get; set; }

        [JsonPropertyName("deductedPart")]
        public string DeductedPart { get; set; }

        [JsonPropertyName("appliedItemIDs")]
        public List<string> AppliedItemIDs { get; set; }

        [JsonPropertyName("freeItem")]
        public FreeItem FreeItem { get; set; }
    }
}
