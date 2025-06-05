using System.Threading.Tasks;

namespace Light.Grab.GrabExpress
{
    public interface IGrabExpressCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}