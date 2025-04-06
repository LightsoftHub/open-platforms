using Light.Shopee.Models;
using Light.Shopee.Models.Shop;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class ShopClient : ShopeeHttpClient, IShopClient
    {
        public ShopClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameterProvider) : base(httpClientFactory, parameterProvider)
        {
        }

        public Task<IShopeeResult<IEnumerable<WarehouseDetailResponse>>> GetWarehouseDetail()
        {
            var patch = "/api/v2/shop/get_warehouse_detail";

            return TryGetAsync<IEnumerable<WarehouseDetailResponse>>(patch);
        }
    }
}
