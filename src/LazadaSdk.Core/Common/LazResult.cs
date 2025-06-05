using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazResult
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

        public static LazResult Success(string message = null)
        {
            return new LazResult
            {
                Code = "0",
                Message = message,
            };
        }

        public static LazResult Failed(string message, string code = "1")
        {
            return new LazResult
            {
                Code = code,
                Message = message,
            };
        }
    }

    public class LazResult<T> : LazResult
    {
        [JsonPropertyName("result")]
        public T Result { get; set; }

        public static LazResult<T> Success(T result)
        {
            return new LazResult<T>
            {
                Code = "0",
                Result = result
            };
        }

        public new static LazResult<T> Failed(string message, string code = "1")
        {
            return new LazResult<T>
            {
                Code = code,
                Message = message,
            };
        }
    }


    public class LazData<T> : LazResult
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}