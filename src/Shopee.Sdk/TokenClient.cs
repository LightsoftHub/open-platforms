using Light.Shopee.Models;
using Light.Shopee.Models.Token;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class TokenClient : ITokenClient
    {
        private readonly HttpClient _httpClient;

        public TokenClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ShopeeAuth");
        }

        public string GetAuthUrl(ShopeeAuthCredential credential, string redirectUrl)
        {
            var urlQuery = credential.GenerateSignedUrl("/api/v2/shop/auth_partner");

            var url = $"{urlQuery}&redirect={redirectUrl}";

            return url;
        }

        private async Task<TokenResponse> GetToken(ShopeeAuthCredential credential, object request)
        {
            var url = credential.GenerateSignedUrl("/api/v2/auth/token/get");

            var response = await _httpClient.PostAsJsonAsync(url, request);

            var result = await response.Content.ReadFromJsonAsync<TokenResponse>()
                ?? throw new Exception("Error when get token.");

            return result;
        }

        public Task<TokenResponse> GetTokenByShopId(ShopeeAuthCredential credential, string code, long shopId)
        {
            return GetToken(credential, new
            {
                partner_id = credential.PartnerId,
                code,
                shop_id = shopId
            });
        }

        public Task<TokenResponse> GetTokenByMainAccountId(ShopeeAuthCredential credential, string code, long mainAccountId)
        {
            return GetToken(credential, new
            {
                partner_id = credential.PartnerId,
                code,
                main_account_id = mainAccountId
            });
        }

        public async Task<RefreshTokenResponse> RefreshToken(ShopeeAuthCredential credential, long shopId, string refreshToken)
        {
            var url = credential.GenerateSignedUrl("/api/v2/auth/access_token/get");

            var request = new
            {
                partner_id = credential.PartnerId,
                shop_id = shopId,
                refresh_token = refreshToken
            };

            var response = await _httpClient.PostAsJsonAsync(url, request);

            var result = await response.Content.ReadFromJsonAsync<RefreshTokenResponse>()
                ?? throw new Exception("Error when refresh token.");

            return result;
        }

        public async Task<string> GetRefreshTokenByUpgradeCode(ShopeeAuthCredential credential, string upgradeCode, long[] shopIds)
        {
            var url = credential.GenerateSignedUrl("/api/v2/public/get_refresh_token_by_upgrade_code");

            var request = new
            {
                partner_id = credential.PartnerId,
                timestamp = credential.Timestamp,
                sign = credential.Sign,
                upgrade_code = upgradeCode,
                shop_id_list = shopIds,
            };

            var response = await _httpClient.PostAsJsonAsync(url, request);

            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}