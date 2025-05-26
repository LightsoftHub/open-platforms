using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabMart
{
    public class GrabMartApiHandler : DelegatingHandler
    {
        private readonly IGrabMartCredential _credential;

        public GrabMartApiHandler(IGrabMartCredential credential)
        {
            _credential = credential;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var baseUrl = request.RequestUri.GetLeftPart(UriPartial.Authority);
            var path = request.RequestUri?.AbsolutePath;
            var query = request.RequestUri?.Query;

            // skip token endpoints
            if (path.Contains("/token") is false)
            {
                var environment = _credential.Environment;

                // check if uri is update order
                if (environment == "grabmart" && IsUpdateOrder(path))
                {
                    // endpoint in PRO difference Staging
                    path = path
                        .Replace("partner/v1/order/", "partner/v1/orders/")
                        .Replace("/edit", "");
                }

                // add environment path to Uri
                var uri = baseUrl + "/" + environment + path + query;

                // override with new Uri
                request.RequestUri = new Uri(uri);

                var token = await _credential.GetAccessToken();
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            return await base.SendAsync(request, cancellationToken);
        }

        private static bool IsUpdateOrder(string path)
        {
            return path.StartsWith("/partner/v1/order/") && path.EndsWith("/edit");
        }
    }
}