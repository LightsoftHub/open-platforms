using Light.Lazada.Models;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface ILazadaCredential
    {
        Task<LazadaApiCredential> GetCredential();
    }
}
