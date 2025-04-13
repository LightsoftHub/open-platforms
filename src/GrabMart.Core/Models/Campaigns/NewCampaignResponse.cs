using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Campaigns
{
    public class NewCampaignResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
