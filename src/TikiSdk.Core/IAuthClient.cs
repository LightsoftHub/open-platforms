using Light.Contracts;
using Light.Tiki.Models;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public interface IAuthClient
    {
        Task<Result<AccessTokenResponse>> GetTokenAsync(string clientId, string clientSecret);
    }
}