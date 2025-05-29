using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    public class GrabExpressApiHandler : DelegatingHandler
    {
        private readonly IGrabExpressCredential _credential;

        public GrabExpressApiHandler(IGrabExpressCredential credential)
        {
            _credential = credential;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var baseUrl = request.RequestUri.GetLeftPart(UriPartial.Authority);
            var path = request.RequestUri?.AbsolutePath;
            var query = request.RequestUri?.Query;

            // add auth before send request
            var token = await _credential.GetAccessToken();
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            // skip add env path when call multi stop
            if (path.StartsWith("/grabfood") is false)
            {
                var environment = _credential.Environment;

                // add environment path to Uri
                var uri = baseUrl + "/" + environment + path + query;

                // override with new Uri
                request.RequestUri = new Uri(uri);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}