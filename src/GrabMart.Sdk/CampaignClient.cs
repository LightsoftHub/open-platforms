using Light.Contracts;
using Light.GrabMart.Models.Campaigns;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public class CampaignClient : GrabMartHttpClient, ICampaignClient
    {
        public CampaignClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<Result<string>> CreateAsync<T>(T request)
            where T : GrabCampaignBase
        {
            var url = $"partner/v1/campaigns";

            try
            {
                var response = await PostAsJsonAsync(url, request);
                var result = await response.ReadObjAsync<NewCampaignResponse>();

                return string.IsNullOrEmpty(result.Id)
                    ? Result<string>.Error("Cannot retrieve campaign ID from grab")
                    : Result<string>.Success(data: result.Id);
            }
            catch (Exception ex)
            {
                return Result<string>.Error(ex.Message);
            }
        }

        public async Task<Result> DeleteAsync(string id)
        {
            var url = $"partner/v1/campaigns/{id}";
            var response = await base.DeleteAsync(url);

            return await response.ToResultAsync();
        }

        public async Task<CampaignListResponse> GetList(string merchantId)
        {
            var url = $"partner/v1/campaigns?merchantID={merchantId}";
            var response = await GetAsync(url);

            return await response.ReadObjAsync<CampaignListResponse>();
        }
    }

}