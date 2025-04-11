using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public class TikiAuthHeaderClientHandler : DelegatingHandler
    {
        private readonly ITikiCredential _credential;

        public TikiAuthHeaderClientHandler(ITikiCredential credential)
        {
            _credential = credential;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.Headers.Clear();

            var oauthPath = "oauth2/token";

            // not load token when Get Token from API to fix error loop send Get Token request
            if (request.RequestUri != null && !request.RequestUri.PathAndQuery.Contains(oauthPath))
            {
                var token = await _credential.GetAccessToken();

                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
