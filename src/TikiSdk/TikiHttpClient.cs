using Light.Contracts;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public abstract class TikiHttpClient
    {
        private readonly HttpClient _httpClient;

        public TikiHttpClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateTikiClient();
        }

        protected async Task<Result<T>> TryGetAsync<T>(string url, CancellationToken cancellationToken = default)
        {
            var res = await _httpClient.GetAsync(url, cancellationToken);

            return await res.ToResult<T>();
        }

        protected async Task<Result> TryPostAsync(string url, object data, CancellationToken cancellationToken = default)
        {
            var res = await _httpClient.PostAsJsonAsync(url, data, cancellationToken);

            return await res.ToResult();
        }

        protected async Task<HttpResponseMessage> PutAsJsonAsync(string url, object data, CancellationToken cancellationToken = default)
        {
            return await _httpClient.PutAsJsonAsync(url, data, cancellationToken);
        }
    }
}
