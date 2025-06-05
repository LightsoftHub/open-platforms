using Light.Contracts;
using Light.Grab.GrabMart.Models.MasterData;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Grab.GrabMart
{
    public class MenuClient : GrabMartHttpClient, IMenuClient
    {
        public MenuClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<MartCategory> GetMartCategories(string region = "VN")
        {
            var url = $"partner/v1/menu/categories?countryCode={region}";
            var response = await GetAsync(url);
            return await response.ReadObjAsync<MartCategory>();
        }

        public async Task<Result> UpdateMenu(string merchantId)
        {
            var url = $"partner/v1/merchant/menu/notification";
            var request = new { merchantID = merchantId };
            var response = await PostAsJsonAsync(url, request);
            return await response.ToResultAsync();
        }

        public async Task<Result> UpdateItem(string merchantId, string itemNo, long price, int maxStock)
        {
            var url = $"partner/v1/menu";
            var request = new
            {
                merchantID = merchantId,
                field = "ITEM",
                id = itemNo,
                price,
                maxStock,
                availableStatus = maxStock > 0 ? "AVAILABLE" : "UNAVAILABLE"
            };

            var response = await PutAsJsonAsync(url, request);
            return await response.ToResultAsync();
        }
    }
}
