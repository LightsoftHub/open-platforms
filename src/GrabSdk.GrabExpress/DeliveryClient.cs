using Light.GrabSdk.GrabExpress.Delivery;
using Light.GrabSdk.GrabExpress.DeliveryQuotes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
            throw new NotImplementedException();
        }

        public Task<DeliveryDetailsResponse> CreateDeliveryRequest(CreateDeliveryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeliveryDetailsResponse> GetDeliveryDetails(string deliveryID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelDelivery(string deliveryID)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CancelDeliveryByMerchantOrderID(string merchantOrderID)
        {
            throw new NotImplementedException();
        }
    }
}
