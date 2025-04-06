using Light.Shopee.Models;
using Light.Shopee.Models.Returns;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IReturnsClient
    {
        // https://open.shopee.com/documents/v2/v2.returns.get_return_list?module=102&type=1
        Task<IShopeeResult<ReturnListResponse>> GetReturnList(GetReturnListRequest request);

        // https://open.shopee.com/documents/v2/v2.returns.get_return_detail?module=102&type=1
        Task<IShopeeResult<ReturnDetailResponse>> GetReturnDetail(string return_sn);
    }
}