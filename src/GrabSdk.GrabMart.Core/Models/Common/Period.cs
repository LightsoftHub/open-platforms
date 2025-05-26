using System;
using System.Text.Json.Serialization;

namespace Light.GrabSdk.GrabMart.Models.Common
{
    public class Period
    {
        public Period() { }

        public Period(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime.ToString(@"hh\:mm");
            EndTime = endTime.ToString(@"hh\:mm");
        }

        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }
    }
}
