using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.MasterData
{
    public class MenuSyncWebhook
    {
        [JsonPropertyName("requestID")]
        public string RequestID { get; set; }

        [JsonPropertyName("merchantID")]
        public string MerchantID { get; set; }

        [JsonPropertyName("jobID")]
        public string JobID { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }
    }
}
