using Light.Contracts;
using Light.Grab.GrabExpress.Delivery.Create;
using Light.Grab.GrabExpress.Delivery.GetQuotes;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Grab.GrabExpress
{
    internal class DeliveryClient : GrabExpressHttpClient, IDeliveryClient
    {
        public DeliveryClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public Task<Result<GetDeliveryQuotesResponse>> GetDeliveryQuotes(GetDeliveryQuotesRequest request)
        {
            var path = "v1/deliveries/quotes";

            return TryPost<GetDeliveryQuotesResponse>(path, request);
        }

        public Task<Result<DeliveryDetailsResponse>> CreateDeliveryRequest(CreateDeliveryRequest request)
        {
            var path = "v1/deliveries";

            return TryPost<DeliveryDetailsResponse>(path, request);
        }

        public Task<Result<DeliveryDetailsResponse>> GetDeliveryDetails(string deliveryID)
        {
            var path = $"v1/deliveries/{deliveryID}";

            return TryGet<DeliveryDetailsResponse>(path);
        }

        public Task<Result> CancelDelivery(string deliveryID)
        {
            var path = $"v1/deliveries/{deliveryID}";

            return TryDelete(path);
        }

        public Task<Result> CancelDeliveryByMerchantOrderID(string merchantOrderID)
        {
            var path = $"v1/merchant/deliveries/{merchantOrderID}";

            return TryDelete(path);
        }
    }
}
