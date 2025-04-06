using Light.Shopee.Models;
using Light.Shopee.Models.Product;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class ProductClient : ShopeeHttpClient, IProductClient
    {
        public ProductClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameters) : base(httpClientFactory, parameters)
        {
        }

        /// inherit docs
        public Task<IShopeeResult<CategoryListResponse>> GetCategories() =>
            TryGetAsync<CategoryListResponse>("/api/v2/product/get_category");

        /// inherit docs
        public Task<IShopeeResult<ItemListResponse>> GetItemList(GetProductListRequest request) =>
            TryGetAsync<ItemListResponse>("/api/v2/product/get_item_list", request);

        /// inherit docs
        public Task<IShopeeResult<ItemBaseInfoResponse>> GetItemBaseInfo(GetItemBaseInfoRequest request) =>
            TryGetAsync<ItemBaseInfoResponse>("/api/v2/product/get_item_base_info", request);

        /// inherit docs
        public Task<IShopeeResult<ItemModelResponse>> GetModelList(long item_id) =>
            TryGetAsync<ItemModelResponse>("/api/v2/product/get_model_list",
                BaseRequest.Create(() => item_id));

        /// inherit docs
        public Task<IShopeeResult<UpdateStockResponse>> UpdateStock(UpdateStockRequest request) =>
            TryPostAsync<UpdateStockResponse>("/api/v2/product/update_stock", request);

        /// inherit docs
        public Task<IShopeeResult<ItemPromotionResponse>> GetItemPromotion(long[] item_id_list) =>
            TryGetAsync<ItemPromotionResponse>("/api/v2/product/get_item_promotion",
                BaseRequest.Create(() => item_id_list));
    }
}