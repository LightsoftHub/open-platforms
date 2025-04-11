using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Products
{
    public class Attributes
    {
        [JsonPropertyName("short_description")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("skin_benefit")]
        public string SkinBenefit { get; set; }

        [JsonPropertyName("fmlt_skin_care")]
        public string FmltSkinCare { get; set; }

        [JsonPropertyName("skin_type")]
        public string SkinType { get; set; }

        [JsonPropertyName("Hazmat")]
        public string Hazmat { get; set; }

        [JsonPropertyName("preorder")]
        public string Preorder { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("delivery_option_sof")]
        public string DeliveryOptionSof { get; set; }
    }
}