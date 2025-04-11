using Light.Lazada.Models;
using Light.Lazada.Models.Auth;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IAuthClient
    {
        Task<TokenResponse> GetTokenAsync(LazadaApiCredential parameters, string authCode);

        Task<TokenResponse> RefreshTokenAsync(LazadaApiCredential parameters, string refreshToken);
    }
}
