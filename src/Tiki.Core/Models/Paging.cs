using System.Text.Json.Serialization;

namespace Light.Tiki.Models
{
    public class Paging
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("from")]
        public int From { get; set; }

        [JsonPropertyName("to")]
        public int To { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("last_page")]
        public int LastPage { get; set; }
    }
}
