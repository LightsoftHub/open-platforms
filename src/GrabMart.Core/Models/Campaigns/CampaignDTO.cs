using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Campaigns
{
    public class CampaignDTO : GrabCampaignBase
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("customTag")]
        public string CustomTag { get; set; }
    }
}
