using Light.Contracts;
using Light.Grab.GrabExpress.MultiStopDelivery.Create;
using Light.Grab.GrabExpress.MultiStopDelivery.GetQuotes;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Grab.GrabExpress
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

        public Task<Result<CreateMultiStopDeliveryResponse>> Create(CreateMultiStopDeliveryRequest request)
        {
            var path = "grabfood-sandbox/partner/express/v1/deliveries";

            return TryPost<CreateMultiStopDeliveryResponse>(path, request);
        }
    }
}
