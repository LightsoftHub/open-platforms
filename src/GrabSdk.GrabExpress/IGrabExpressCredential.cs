using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    public interface IGrabExpressCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}