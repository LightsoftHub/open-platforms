using Light.Contracts;
using Light.Grab.GrabExpress.MultiStopDelivery.Create;
using Light.Grab.GrabExpress.MultiStopDelivery.GetQuotes;
using System.Threading.Tasks;

namespace Light.Grab.GrabExpress
{
    public interface IMultiStopDeliveryClient
    {
        Task<Result<GetMultiStopDeliveryQuotesResponse>> GetQuotes(GetMultiStopDeliveryQuotesRequest request);

        Task<Result<CreateMultiStopDeliveryResponse>> Create(CreateMultiStopDeliveryRequest request);
    }
}
