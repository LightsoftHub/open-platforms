using Light.Contracts;
using Light.GrabSdk.GrabExpress.MultiStopDelivery.GetQuotes;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    internal class MultiStopDeliveryClient : GrabExpressHttpClient, IMultiStopDeliveryClient
    {
        public MultiStopDeliveryClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public Task<Result<GetMultiStopDeliveryQuotesResponse>> GetQuotes(GetMultiStopDeliveryQuotesRequest request)
        {
            var path = "grabfood-sandbox/partner/express/v1/deliveries/quotes";

            return TryPost<GetMultiStopDeliveryQuotesResponse>(path, request);
        }
    }
}
