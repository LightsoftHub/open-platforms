using Light.Shopee.Models.Public;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class PublicClient : ShopeeHttpClient, IPublicClient
    {
        public PublicClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameters) : base(httpClientFactory, parameters)
        {
        }

        public async Task<IpListResponse> GetShopeeIpRanges()
        {
            var patch = "/api/v2/public/get_shopee_ip_ranges";

            var response = await GetAsync(patch);

            var responseStr = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<IpListResponse>(responseStr);
        }
    }
}
