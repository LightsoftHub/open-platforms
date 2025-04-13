using Light.GrabMart.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public class AuthClient : IAuthClient
    {
        private readonly HttpClient _httpClient;

        public AuthClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateGrabMartAuthClient();
        }

        public async Task<TokenResponse> GetTokenAsync(string clientId, string clientSecret, string scope = "mart.partner_api")
        {
            var path = "grabid/v1/oauth2/token";

            var request = new
            {
                client_id = clientId,
                client_secret = clientSecret,
                grant_type = "client_credentials",
                scope
            };

            var response = await _httpClient.PostAsJsonAsync(path, request);
            var obj = await response.ReadObjAsync<TokenResponse>();
            return obj;
        }
    }
}
