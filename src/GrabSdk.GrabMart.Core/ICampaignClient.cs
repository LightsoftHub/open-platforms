using Light.Contracts;
using Light.Grab.GrabMart.Models.Campaigns;
using System.Threading.Tasks;

namespace Light.Grab.GrabMart
{
    public interface ICampaignClient
    {
        Task<CampaignListResponse> GetList(string merchantId);

        Task<Result<string>> CreateAsync<T>(T request)
            where T : GrabCampaignBase;

        Task<Result> DeleteAsync(string id);
    }
}
