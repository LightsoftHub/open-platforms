using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.GrabMart.Models.Common
{
    public class ServiceHourPeriod
    {
        [JsonPropertyName("openPeriodType")]
        public string OpenPeriodType { get; private set; } = "OpenPeriod";

        [JsonPropertyName("periods")]
        public IList<Period> Periods { get; set; }
    }
}
