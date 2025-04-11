using Light.Contracts;
using Light.Tiki.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public static class TikiResultExtensions
    {
        public static async Task<Result<T>> ToResult<T>(this HttpResponseMessage response)
        {
            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var dto = JsonSerializer.Deserialize<T>(responseStr);
                if (dto != null)
                {
                    return Result<T>.Success(dto);
                }
            }

            var error = JsonSerializer.Deserialize<ErrorBody>(responseStr);
            if (error != null)
            {
                var errorMsg = $"{error.Meta.Id} - {error.Meta.Source}";

                if (error.Errors != null)
                {
                    errorMsg += string.Join("|", error.Errors);
                }

                return Result<T>.Error(errorMsg);
            }

            return Result<T>.Error(responseStr);
        }

        public static async Task<Result> ToResult(this HttpResponseMessage response)
        {
            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<CodeResult>(responseStr);
                if (result != null && result.Code == 200)
                {
                    return Result.Success();
                }
            }

            var error = JsonSerializer.Deserialize<ErrorBody>(responseStr);
            if (error != null)
            {
                var errorMsg = $"{error.Meta.Id} - {error.Meta.Source}";

                if (error.Errors != null)
                {
                    errorMsg += string.Join("|", error.Errors);
                }

                return Result.Error(errorMsg);
            }

            return Result.Error(responseStr);
        }
    }
}
