using Light.Lazada.Common;
using Light.Lazada.Models.Products;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public class ProductClient : LazadaHttpClient, IProductClient
    {
        public ProductClient(IHttpClientFactory httpClientFactory, ILazadaCredential provider) : base(httpClientFactory, provider)
        {
        }

        public async Task<LazResult<Product>> GetProductItem(string sellerSku, string itemId)
        {
            var path = "/product/item/get";
            var request = new Dictionary<string, string>()
        {
            { "seller_sku", sellerSku },
        };

            if (string.IsNullOrEmpty(itemId) is false)
            {
                request = new Dictionary<string, string>()
            {
                { "item_id", itemId },
            };
            }

            var response = await TryGetAsync(path, request);

            var result = await response.ReadData<Product>();

            return result;
        }

        public async Task<LazResult<ProductList>> GetProducts(int offset = 0, int limit = 50,
            DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null,
            DateTimeOffset? updateAfter = null, DateTimeOffset? updateBefore = null)
        {
            var path = "/products/get";
            var request = new Dictionary<string, string>()
            {
                { "offset", offset.ToString() },
                { "limit", limit.ToString() },
                { "options", "1" }, // Options=1 means contain ReservedStock, RtsStock, PendingStock, RealTimeStock, FulfillmentBySellable.
            };

            if (createdAfter.HasValue) // create from
                request.Add("create_after", createdAfter.ToLazDate());

            if (createdAfter.HasValue) // create to
                request.Add("create_before", createdBefore.ToLazDate());

            if (updateAfter.HasValue) // update from
                request.Add("update_after", updateAfter.ToLazDate());

            if (updateAfter.HasValue) // update to
                request.Add("update_before", updateBefore.ToLazDate());

            var response = await TryGetAsync(path, request);

            var result = await response.ReadData<ProductList>();

            return result;
        }

        public async Task<LazResult> AdjustSellableQuantity(UploadStockRequest dto)
        {
            var path = "/product/stock/sellable/adjust";
            var request = new Dictionary<string, string>()
            {
                { "payload", dto.Payload },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.ReadDetail();

            return result;
        }

        public async Task<LazResult> UpdateSellableQuantity(UploadStockRequest dto)
        {
            var path = "/product/stock/sellable/update";
            var request = new Dictionary<string, string>()
            {
                { "payload", dto.Payload },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.ReadDetail();

            return result;
        }
    }
}
