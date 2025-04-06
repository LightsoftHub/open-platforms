using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Light.Shopee
{
    public class SignUrlHandler : DelegatingHandler
    {
        private readonly IShopeeCredential _credential;

        public SignUrlHandler(IShopeeCredential credential)
        {
            _credential = credential;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var path = request.RequestUri?.AbsolutePath;
            var query = request.RequestUri?.Query;

            if (query.StartsWith("?"))
                query = "&" + query.Substring(1);

            var signedUrl = (await _credential.GetCredential()).GenerateSignedUrl(path);

            // override url by new signed Url
            Console.WriteLine($"{signedUrl}{query}");
            //request.RequestUri = uri;

            return await base.SendAsync(request, cancellationToken);
        }
    }
}