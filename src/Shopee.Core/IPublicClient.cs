using Light.Shopee.Models.Public;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IPublicClient
    {
        Task<IpListResponse> GetShopeeIpRanges();
    }
}
