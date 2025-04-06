using Light.Shopee.Models;
using Light.Shopee.Models.PushConfig;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface IPushClient
    {
        Task<IShopeeResult<SetPushConfigRequest>> GetConfig();

        Task<IShopeeResult> SetConfig(string callBackUrl, PushConfigType[] types);
    }
}
