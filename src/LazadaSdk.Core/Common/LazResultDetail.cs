using Light.Lazada.Models.Products;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazResultDetail : LazResult<List<UploadStockResponse>>
    {
        private List<UploadStockResponse> _detail;

        [JsonPropertyName("detail")]
        public List<UploadStockResponse> Detail { get { return Result; } set { Result = value; } }
    }
}
