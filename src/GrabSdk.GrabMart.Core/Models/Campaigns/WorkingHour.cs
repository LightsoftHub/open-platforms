using Light.GrabSdk.GrabMart.Models.Common;
using System.Text.Json.Serialization;

namespace Light.GrabSdk.GrabMart.Models.Campaigns
{
    /// <summary>
    /// Use for Campaign
    /// </summary>
    public class WorkingHour
    {
        [JsonPropertyName("sun")]
        public virtual ServiceHourPeriod Sun { get; set; }

        [JsonPropertyName("mon")]
        public virtual ServiceHourPeriod Mon { get; set; }

        [JsonPropertyName("tue")]
        public virtual ServiceHourPeriod Tue { get; set; }

        [JsonPropertyName("wed")]
        public virtual ServiceHourPeriod Wed { get; set; }

        [JsonPropertyName("thu")]
        public virtual ServiceHourPeriod Thu { get; set; }

        [JsonPropertyName("fri")]
        public virtual ServiceHourPeriod Fri { get; set; }

        [JsonPropertyName("sat")]
        public virtual ServiceHourPeriod Sat { get; set; }
    }
}
