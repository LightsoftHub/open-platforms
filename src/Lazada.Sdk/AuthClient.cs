using Light.Lazada.Models;
using Light.Lazada.Models.Auth;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public class AuthClient : IAuthClient
    {
        private readonly HttpClient _httpClient;

        public AuthClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("LazadaAuth");
        }

        public async Task<TokenResponse> GetTokenAsync(LazadaApiCredential parameters, string authCode)
        {
            var path = "/auth/token/create";

            var request = new Dictionary<string, string>()
            {
                { "code", authCode },
            };

            var url = parameters.GenerateAuthUrl(path, request);

            var result = await _httpClient.GetFromJsonAsync<TokenResponse>(url)
                ?? throw new Exception("lazada_auth error when get token");

            return result;
        }

        public async Task<TokenResponse> RefreshTokenAsync(LazadaApiCredential parameters, string refreshToken)
        {
            var path = "/auth/token/refresh";

            var request = new Dictionary<string, string>()
            {
                { "refresh_token", refreshToken },
            };

            var url = parameters.GenerateAuthUrl(path, request);

            var result = await _httpClient.GetFromJsonAsync<TokenResponse>(url)
                ?? throw new Exception("lazada_auth error when refresh token");

            return result;
        }
    }
}
