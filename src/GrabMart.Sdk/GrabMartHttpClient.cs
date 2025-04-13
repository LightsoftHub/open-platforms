using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public abstract class GrabMartHttpClient
    {
        private readonly HttpClient _httpClient;

        public GrabMartHttpClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateGrabMartClient();
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
    }
}
