using Light.GrabMart.Models;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public interface IAuthClient
    {
        Task<TokenResponse> GetTokenAsync(string clientId, string clientSecret, string scope = "mart.partner_api");
    }
}