using Light.Shopee.Models;
using Light.Shopee.Models.Product;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IProductClient
    {
        // https://open.shopee.com/documents/v2/v2.product.get_category?module=89&type=1
        Task<IShopeeResult<CategoryListResponse>> GetCategories();

        // https://open.shopee.com/documents/v2/v2.product.get_item_list?module=89&type=1
        Task<IShopeeResult<ItemListResponse>> GetItemList(GetProductListRequest request);

        // https://open.shopee.com/documents/v2/v2.product.get_item_base_info?module=89&type=1
        Task<IShopeeResult<ItemBaseInfoResponse>> GetItemBaseInfo(GetItemBaseInfoRequest request);

        // https://open.shopee.com/documents/v2/v2.product.get_model_list?module=89&type=1
        Task<IShopeeResult<ItemModelResponse>> GetModelList(long itemId);

        // https://open.shopee.com/documents/v2/v2.product.update_stock?module=89&type=1
        Task<IShopeeResult<UpdateStockResponse>> UpdateStock(UpdateStockRequest request);

        // https://open.shopee.com/documents/v2/v2.product.get_item_promotion?module=89&type=1
        Task<IShopeeResult<ItemPromotionResponse>> GetItemPromotion(long[] itemIdList);
    }
}