using System.Text.Json.Serialization;

namespace Light.Shopee.Models.Token
{
    public class TokenResponse : ShopeeResult
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("expire_in")]
        public int ExpireIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}