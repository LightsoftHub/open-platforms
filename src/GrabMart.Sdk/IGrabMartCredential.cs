using System.Threading.Tasks;

namespace Light.GrabMart
{
    public interface IGrabMartCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}