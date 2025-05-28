using Light.Contracts;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    public abstract class GrabExpressHttpClient
    {
        private readonly HttpClient _httpClient;

        public GrabExpressHttpClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateGrabExpressClient();
        }

        protected Task<HttpResponseMessage> GetAsync(string url, CancellationToken cancellationToken = default)
        {
            return _httpClient.GetAsync(url, cancellationToken);
        }

        protected Task<HttpResponseMessage> PostAsJsonAsync(string url, object data, CancellationToken cancellationToken = default)
        {
            return _httpClient.PostAsJsonAsync(url, data, cancellationToken);
        }

        protected Task<HttpResponseMessage> PutAsJsonAsync(string url, object data, CancellationToken cancellationToken = default)
        {
            return _httpClient.PutAsJsonAsync(url, data, cancellationToken);
        }

        protected Task<HttpResponseMessage> DeleteAsync(string url, CancellationToken cancellationToken = default)
        {
            return _httpClient.DeleteAsync(url, cancellationToken);
        }

        protected async Task<T> Get<T>(string url, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync(url, cancellationToken);

            var result = await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);

            return result == null
                ? throw new HttpRequestException($"Failed to deserialize response from {url}")
                : result;
        }

        protected async Task<T> Post<T>(string url, object request, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.PostAsJsonAsync(url, request, cancellationToken);

            var result = await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);

            return result == null
                ? throw new HttpRequestException($"Failed to deserialize response from {url}")
                : result;
        }

        protected async Task<Result> TryDelete(string url, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.DeleteAsync(url, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                return Result.Success();
            }

            var errorContent = await response.Content.ReadAsStringAsync();

            return Result.Error(errorContent);
        }
    }
}
