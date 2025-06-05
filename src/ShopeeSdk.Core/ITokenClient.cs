using Light.Shopee.Models;
using Light.Shopee.Models.Token;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public interface ITokenClient
    {
        // Get url from shopee to authorize app and get code for get token
        string GetAuthUrl(ShopeeAuthCredential credential, string redirectUrl);

        // Get token after authorize app and have code, use that code to get token (4 hours)
        Task<TokenResponse> GetTokenByShopId(ShopeeAuthCredential credential, string code, long shopId);
        Task<TokenResponse> GetTokenByMainAccountId(ShopeeAuthCredential credential, string code, long mainAccountId);

        // Refresh token from shopee (30 days)
        Task<RefreshTokenResponse> RefreshToken(ShopeeAuthCredential credential, long shopId, string refreshToken);

        // https://open.shopee.com/documents/v2/v2.public.get_refresh_token_by_upgrade_code?module=104&type=1
        Task<string> GetRefreshTokenByUpgradeCode(ShopeeAuthCredential credential, string upgradeCode, long[] shopIds);
    }
}