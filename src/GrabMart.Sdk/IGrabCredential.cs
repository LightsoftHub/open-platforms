using System.Threading.Tasks;

namespace Light.GrabMart
{
    public interface IGrabCredential
    {
        string Environment { get; }

        Task<string> GetAccessToken();
    }
}