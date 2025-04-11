using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public class LazadaHttpClient
    {
        protected readonly HttpClient _httpClient;
        private readonly ILazadaCredential _provider;

        public LazadaHttpClient(IHttpClientFactory httpClientFactory, ILazadaCredential provider)
        {
            _httpClient = httpClientFactory.CreateLazClient();
            _provider = provider;
        }

        protected async Task<HttpResponseMessage> TryGetAsync(string path, Dictionary<string, string> request)
        {
            var url = (await _provider.GetCredential()).GenerateQueryUrl(path, request);

            return await _httpClient.GetAsync(url);
        }

        protected async Task<HttpResponseMessage> TryPostAsync(string path, Dictionary<string, string> request)
        {
            var url = (await _provider.GetCredential()).GenerateQueryUrl(path, request);

            return await _httpClient.PostAsJsonAsync(url, request);
        }
    }
}
