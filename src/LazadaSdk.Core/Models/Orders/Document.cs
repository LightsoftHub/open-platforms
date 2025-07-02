using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Orders
{
    public class OrderDocument
    {
        [JsonPropertyName("document")]
        public Document Document { get; set; }
    }

    public class Document
    {
        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }

        [JsonPropertyName("document_type")]
        public string DocumentType { get; set; }
    }
}
