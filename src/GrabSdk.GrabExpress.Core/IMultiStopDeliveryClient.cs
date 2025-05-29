using Light.Contracts;
using Light.GrabSdk.GrabExpress.MultiStopDelivery.GetQuotes;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabExpress
{
    public interface IMultiStopDeliveryClient
    {
        Task<Result<GetMultiStopDeliveryQuotesResponse>> GetQuotes(GetMultiStopDeliveryQuotesRequest request);
    }
}
