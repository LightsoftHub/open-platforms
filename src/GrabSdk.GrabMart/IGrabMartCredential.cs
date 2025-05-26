using System.Threading.Tasks;

namespace Light.GrabSdk.GrabMart
{
    public interface IGrabMartCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}