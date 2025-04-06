using Light.Shopee.Models;
using Light.Shopee.Models.Shop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IShopClient
    {
        // https://open.shopee.com/documents/v2/v2.shop.get_warehouse_detail?module=92&type=1
        Task<IShopeeResult<IEnumerable<WarehouseDetailResponse>>> GetWarehouseDetail();
    }
}