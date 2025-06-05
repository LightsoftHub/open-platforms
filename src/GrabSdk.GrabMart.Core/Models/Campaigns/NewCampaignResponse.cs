using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Campaigns
{
    public class NewCampaignResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
