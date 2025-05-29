using Light.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected async Task<Result<T>> TryGet<T>(string url, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.GetAsync(url, cancellationToken);

            return await AsResultFrom<T>(response);
        }

        protected async Task<Result<T>> TryPost<T>(string url, object request, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.PostAsJsonAsync(url, request, cancellationToken);

            return await AsResultFrom<T>(response);
        }

        protected async Task<Result> TryDelete(string url, CancellationToken cancellationToken = default)
        {
            var response = await _httpClient.DeleteAsync(url, cancellationToken);

            return await AsResultFrom(response);
        }

        private async Task<Result> AsResultFrom(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return Result.Success();
            }

            return await ReadError(response);
        }

        private async Task<Result<T>> AsResultFrom<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<T>();

                return Result<T>.Success(data);
            }

            var error = await ReadError(response);

            return Result<T>.Error(error.Message);
        }

        private async Task<Result> ReadError(HttpResponseMessage response)
        {
            var statusCode = (int)response.StatusCode;

            var contentStr = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(contentStr))
            {
                return Result.Error($"ResponseCode: {statusCode}");
            }

            try
            {
                var errorContent = JsonSerializer.Deserialize<Dictionary<string, object>>(contentStr);

                var errors = errorContent.Select(s => $"{s.Key}: {s.Value}").ToList();

                return Result.Error($"ResponseCode: {statusCode}|{string.Join("|", errors)}");
            }
            catch (Exception ex)
            {
                return Result.Error($"ResponseCode: {statusCode}|{contentStr}|{ex.Message}");
            }
        }
    }
}
