using Light.Contracts;
using Light.Grab.GrabExpress.Delivery.Create;
using Light.Grab.GrabExpress.Delivery.GetQuotes;
using System.Threading.Tasks;

namespace Light.Grab.GrabExpress
{
    public interface IDeliveryClient
    {
        // https://developer.grab.com/docs/grab-express#get-delivery-quotes
        Task<Result<GetDeliveryQuotesResponse>> GetDeliveryQuotes(GetDeliveryQuotesRequest request);

        // https://developer.grab.com/docs/grab-express#create-delivery-request
        Task<Result<DeliveryDetailsResponse>> CreateDeliveryRequest(CreateDeliveryRequest request);

        // https://developer.grab.com/docs/grab-express#get-delivery-details
        Task<Result<DeliveryDetailsResponse>> GetDeliveryDetails(string deliveryID);

        // https://developer.grab.com/docs/grab-express#cancel-delivery
        Task<Result> CancelDelivery(string deliveryID);

        // https://developer.grab.com/docs/grab-express#cancel-delivery-by-merchant-order-id
        Task<Result> CancelDeliveryByMerchantOrderID(string merchantOrderID);
    }
}
