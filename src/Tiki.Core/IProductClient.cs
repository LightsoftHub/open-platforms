using Light.Contracts;
using Light.Tiki.Models.Products;
using System;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public interface IProductClient
    {
        Task<Result<ProductsList>> GetProducts(int page = 1, DateTime? updateFrom = null);

        // https://open.tiki.vn/docs/docs/current/api-references/product-api/#update-variant-price-quantity-active-v2-1
        Task<Result> UpdateQuantity(long productId, WarehouseQtyRequest[] warehouses);
    }
}