using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazData<T> : LazResponse<T>, ILazResponse<T>
    {
        [JsonPropertyName("data")]
        public override T Data { get; set; }
    }
}
