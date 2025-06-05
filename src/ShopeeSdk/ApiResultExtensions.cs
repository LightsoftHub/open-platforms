using Light.Shopee.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal static class ApiResultExtensions
    {
        public static async Task<IShopeeResult> Read(this HttpResponseMessage response)
        {
            var result = await response.Content.ReadFromJsonAsync<ShopeeResult>();

            if (result is null)
                return ShopeeResult.Failed("error when read HttpResponse");
            else
                return result;
        }

        public static async Task<IShopeeResult<T>> ReadAs<T>(this HttpResponseMessage response)
        {
            var result = await response.Content.ReadFromJsonAsync<ShopeeResult<T>>();

            if (result is null)
                return ShopeeResult<T>.Failed("error when read HttpResponse");
            else
                return result;
        }
    }
}