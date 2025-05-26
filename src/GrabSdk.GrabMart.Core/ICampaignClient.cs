using Light.Contracts;
using Light.GrabSdk.GrabMart.Models.Campaigns;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabMart
{
    public interface ICampaignClient
    {
        Task<CampaignListResponse> GetList(string merchantId);

        Task<Result<string>> CreateAsync<T>(T request)
            where T : GrabCampaignBase;

        Task<Result> DeleteAsync(string id);
    }
}
