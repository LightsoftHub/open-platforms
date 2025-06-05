using System.Text.Json.Serialization;

namespace Light.Shopee.Models
{
    public interface IShopeeResult
    {
        string Error { get; }

        string Message { get; }

        string RequestId { get; }

        bool Succeeded { get; }

        string Warning { get; }
    }

    public interface IShopeeResult<T> : IShopeeResult
    {
        T Response { get; }
    }

    public class ShopeeResult : IShopeeResult
    {
        [JsonPropertyOrder(-1)]
        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyOrder(-1)]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyOrder(-1)]
        [JsonPropertyName("warning")]
        public string Warning { get; set; }

        [JsonPropertyOrder(-1)]
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        [JsonPropertyOrder(-1)]
        public bool Succeeded => string.IsNullOrEmpty(Error) && string.IsNullOrEmpty(Message);

        public static IShopeeResult Failed(string message)
        {
            return new ShopeeResult
            {
                Error = "error.manual",
                Message = message
            };
        }
    }

    public class ShopeeResult<T> : ShopeeResult, IShopeeResult<T>
    {
        [JsonPropertyName("response")]
        public T Response { get; set; }

        public static IShopeeResult<T> Success(T data)
        {
            return new ShopeeResult<T>
            {
                Response = data,
            };
        }

        public new static IShopeeResult<T> Failed(string message)
        {
            return new ShopeeResult<T>
            {
                Error = "error.manual",
                Message = message
            };
        }
    }
}