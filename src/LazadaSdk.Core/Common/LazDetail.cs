using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazDetail<T> : LazResponse<T>, ILazResponse<T>
    {
        [JsonPropertyName("detail")]
        public override T Data { get; set; }
    }
}
