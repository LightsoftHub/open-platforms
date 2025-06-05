using System.Threading.Tasks;

namespace Light.Tiki
{
    public interface ITikiCredential
    {
        Task<string> GetAccessToken();
    }
}
