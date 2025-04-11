using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Fulfillments
{
    public class PrintAWBData
    {
        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("pdf_url")]
        public string PdfUrl { get; set; }

        [JsonPropertyName("doc_type")]
        public string DocType { get; set; }
    }

    public class PrintAWBResult
    {
        [JsonPropertyName("data")]
        public PrintAWBData Data { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
