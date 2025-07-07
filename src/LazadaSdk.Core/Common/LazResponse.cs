using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazResponse
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        public bool IsSuccess => Code.Equals("0");

        public static LazResponse Success(string message = null)
        {
            return new LazResponse
            {
                Code = "0",
                Message = message,
            };
        }

        public static LazResponse Failed(string message, string code = "1")
        {
            return new LazResponse
            {
                Code = code,
                Message = message,
            };
        }
    }

    public abstract class LazResponse<T> : LazResponse, ILazResponse<T>
    {
        public abstract T Data { get; set; }

        public static ILazResponse<T> Success(T result)
        {
            return new LazData<T>
            {
                Code = "0",
                Data = result
            };
        }

        public new static ILazResponse<T> Failed(string message, string code = "1")
        {
            return new LazData<T>
            {
                Code = code,
                Message = message,
            };
        }
    }
}