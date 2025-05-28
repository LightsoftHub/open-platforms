using Light.Contracts;
using Light.GrabSdk.GrabExpress.Delivery;
using Light.GrabSdk.GrabExpress.DeliveryQuotes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    internal class DeliveryClient : GrabExpressHttpClient, IDeliveryClient
    {
        public DeliveryClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public Task<GetDeliveryQuotesResponse> GetDeliveryQuotes(GetDeliveryQuotesRequest request)
        {
            var path = "v1/deliveries/quotes";

            return Post<GetDeliveryQuotesResponse>(path, request);
        }

        public Task<DeliveryDetailsResponse> CreateDeliveryRequest(CreateDeliveryRequest request)
        {
            var path = "v1/deliveries";

            return Post<DeliveryDetailsResponse>(path, request);
        }

        public Task<DeliveryDetailsResponse> GetDeliveryDetails(string deliveryID)
        {
            var path = $"v1/deliveries/{deliveryID}";

            return Get<DeliveryDetailsResponse>(path);
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
