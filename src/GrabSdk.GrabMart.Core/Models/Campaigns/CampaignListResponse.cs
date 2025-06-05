using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Campaigns
{
    public class CampaignListResponse
    {
        [JsonPropertyName("ongoing")]
        public IEnumerable<CampaignDTO> Ongoing { get; set; }

        [JsonPropertyName("upcoming")]
        public IEnumerable<CampaignDTO> Upcoming { get; set; }
    }
}
