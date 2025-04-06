using Light.Shopee.Models;
using Light.Shopee.Models.Returns;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class ReturnsClient : ShopeeHttpClient, IReturnsClient
    {
        public ReturnsClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameterProvider) : base(httpClientFactory, parameterProvider)
        {
        }

        public Task<IShopeeResult<ReturnListResponse>> GetReturnList(GetReturnListRequest request) =>
            TryGetAsync<ReturnListResponse>("/api/v2/returns/get_return_list", request);

        public Task<IShopeeResult<ReturnDetailResponse>> GetReturnDetail(string return_sn) =>
            TryGetAsync<ReturnDetailResponse>("/api/v2/returns/get_return_detail",
                BaseRequest.Create(() => return_sn));
    }
}