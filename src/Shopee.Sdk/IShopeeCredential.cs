using Light.Shopee.Models;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IShopeeCredential
    {
        Task<ShopeeApiCredential> GetCredential();
    }
}
