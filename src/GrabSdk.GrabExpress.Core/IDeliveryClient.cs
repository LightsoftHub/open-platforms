using Light.GrabSdk.GrabExpress.Delivery;
using Light.GrabSdk.GrabExpress.DeliveryQuotes;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    public interface IDeliveryClient
    {
        // https://developer.grab.com/docs/grab-express#get-delivery-quotes
        Task<GetDeliveryQuotesResponse> GetDeliveryQuotes(GetDeliveryQuotesRequest request);

        // https://developer.grab.com/docs/grab-express#create-delivery-request
        Task<DeliveryDetailsResponse> CreateDeliveryRequest(CreateDeliveryRequest request);

        // https://developer.grab.com/docs/grab-express#get-delivery-details
        Task<DeliveryDetailsResponse> GetDeliveryDetails(string deliveryID);

        // https://developer.grab.com/docs/grab-express#cancel-delivery
        Task<bool> CancelDelivery(string deliveryID);

        // https://developer.grab.com/docs/grab-express#cancel-delivery-by-merchant-order-id
        Task<bool> CancelDeliveryByMerchantOrderID(string merchantOrderID);
    }
}
