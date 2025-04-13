using Light.Contracts;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public class GrabResult
    {
        [JsonPropertyName("target")]
        public string Target { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

    public static class ResultExtensions
    {
        public static async Task<Result> ToResultAsync(this HttpResponseMessage message)
        {
            if (message.IsSuccessStatusCode)
            {
                return Result.Success();
            }

            var resultStr = await message.Content.ReadAsStringAsync();

            return Result.Error(resultStr);
        }

        public static async Task<T> ReadObjAsync<T>(this HttpResponseMessage message)
        {
            var isSuccessCode = message.IsSuccessStatusCode;

            var responseString = await message.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(responseString))
            {
                throw new Exception("Empty response");
            }

            if (isSuccessCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                var obj = JsonSerializer.Deserialize<T>(responseString, options);

                return obj == null
                    ? throw new ArgumentNullException(typeof(T).Name)
                    : obj;
            }

            var result = JsonSerializer.Deserialize<GrabResult>(responseString);

            throw new Exception($"{result.Reason} - {result.Message}");
        }
    }
}
