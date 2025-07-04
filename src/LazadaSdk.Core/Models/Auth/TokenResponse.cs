using Light.Lazada.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Models.Auth
{
    public class TokenResponse : LazResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("country_user_info_list")]
        public List<CountryUserInfoList> CountryUserInfoList { get; set; }

        [JsonPropertyName("account_platform")]
        public string AccountPlatform { get; set; }

        [JsonPropertyName("refresh_expires_in")]
        public int RefreshExpiresIn { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("account")]
        public string Account { get; set; }
    }

    public class CountryUserInfoList
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; }
    }
}