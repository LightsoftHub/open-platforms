using Light.Contracts;
using Light.Tiki.Models;
using Light.Tiki.Models.Products;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public class ProductApiClient : TikiHttpClient, IProductClient
    {
        public ProductApiClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<Result<ProductsList>> GetProducts(int page = 1, DateTime? updateFrom = null)
        {
            var url = "integration/v2.1/products?include=inventory";
            url += $"&page={page}&limit=50";

            if (updateFrom.HasValue)
                url += $"&updated_from_date={updateFrom:yyyy-MM-dd HH:mm:ss}";

            return await GetAsync<ProductsList>(url);
        }

        public async Task<Result> UpdateQuantity(long productId, WarehouseQtyRequest[] warehouses)
        {
            var url = "integration/v2.1/products/updateSku";

            var warehouseIds = warehouses.Select(s => s.WarehouseId.ToString());

            var request = new
            {
                product_id = productId,
                seller_warehouse = string.Join(", ", warehouseIds),
                warehouse_quantities = warehouses
            };

            var response = await PutAsJsonAsync(url, request);

            var responseStr = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var obj = JsonSerializer.Deserialize<StateResult>(responseStr);

                if (obj != null && obj.State == "approved")
                    return Result.Success();
            }

            var errors = JsonSerializer.Deserialize<ErrorBody>(responseStr);
            if (errors != null)
            {
                var errorMsg = $"{errors.Meta.Id} - {errors.Meta.Source}";
                if (errors.Errors != null)
                {
                    errorMsg += string.Join("|", errors.Errors);
                }

                return Result.Error(errorMsg);
            }

            return Result.Error(responseStr);
        }
    }

}