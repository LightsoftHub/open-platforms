using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Grab.Auth
{
    public class GrabAuthClient
    {
        private readonly HttpClient _httpClient;

        public GrabAuthClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TokenResponse> GetTokenAsync(string clientId, string clientSecret, string scope)
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

            return await response.Content.ReadFromJsonAsync<TokenResponse>();
        }
    }
}
