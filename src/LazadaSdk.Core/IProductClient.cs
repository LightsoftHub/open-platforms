using Light.Lazada.Common;
using Light.Lazada.Models.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IProductClient
    {
        /// <summary>
        /// https://open.lazada.com/apps/doc/api?path=%2Fproduct%2Fitem%2Fget
        /// </summary>
        Task<ILazResponse<Product>> GetProductItem(string itemId);

        /// <summary>
        /// https://open.lazada.com/apps/doc/api?path=%2Fproducts%2Fget
        /// </summary>
        Task<ILazResponse<ProductList>> GetProducts(int offset = 0, int limit = 50,
            DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null,
            DateTimeOffset? updateAfter = null, DateTimeOffset? updateBefore = null);

        /// <summary>
        /// https://open.lazada.com/apps/doc/api?path=%2Fproduct%2Fstock%2Fsellable%2Fadjust
        ///     this api will use current stock - upload qty (error if adjust qty < 0)
        /// </summary>
        Task<ILazResponse<List<UploadStockResponse>>> AdjustSellableQuantity(UploadStockRequest dto);

        /// <summary>
        /// https://open.lazada.com/apps/doc/api?spm=a1zq7z.man108146.site_detail.18.a0137c7307vc5p&path=%2Fproduct%2Fstock%2Fsellable%2Fupdate
        /// </summary>
        Task<ILazResponse<List<UploadStockResponse>>> UpdateSellableQuantity(UploadStockRequest dto);
    }
}
