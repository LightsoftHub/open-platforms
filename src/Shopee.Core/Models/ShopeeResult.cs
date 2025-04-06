using System.Text.Json.Serialization;

namespace Light.Shopee.Models
{
    public interface IShopeeResult
    {
        string error { get; }
        string message { get; }
        string request_id { get; }
        bool succeeded { get; }
        string warning { get; }
    }

    public interface IShopeeResult<T> : IShopeeResult
    {
        T response { get; }
    }

    public class ShopeeResult : IShopeeResult
    {
        [JsonPropertyOrder(-1)]
        public string error { get; set; }

        [JsonPropertyOrder(-1)]
        public string message { get; set; }

        [JsonPropertyOrder(-1)]
        public string warning { get; set; }

        [JsonPropertyOrder(-1)]
        public string request_id { get; set; }

        [JsonPropertyOrder(-1)]
        public bool succeeded => string.IsNullOrEmpty(error) && string.IsNullOrEmpty(message);

        public static IShopeeResult Failed(string message)
        {
            return new ShopeeResult
            {
                error = "error.manual",
                message = message
            };
        }
    }

    public class ShopeeResult<T> : ShopeeResult, IShopeeResult<T>
    {
        public T response { get; set; }

        public static IShopeeResult<T> Success(T data)
        {
            return new ShopeeResult<T>
            {
                response = data,
            };
        }

        public new static IShopeeResult<T> Failed(string message)
        {
            return new ShopeeResult<T>
            {
                error = "error.manual",
                message = message
            };
        }
    }
}