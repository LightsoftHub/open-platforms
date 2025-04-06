using Light.Shopee.Models;
using Light.Shopee.Models.PushConfig;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace Light.Shopee
{
    internal class PushClient : ShopeeHttpClient, IPushClient
    {
        public PushClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameterProvider) : base(httpClientFactory, parameterProvider)
        {
        }

        public Task<IShopeeResult<SetPushConfigRequest>> GetConfig()
        {
            var patch = "/api/v2/push/get_app_push_config";

            return TryGetAsync<SetPushConfigRequest>(patch);
        }

        public Task<IShopeeResult> SetConfig(string callBackUrl, PushConfigType[] types)
        {
            var patch = "/api/v2/push/set_app_push_config";

            var allTypes = Enum.GetValues(typeof(PushConfigType)).Cast<PushConfigType>();

            var onList = types.Select(s => (int)s).ToList();

            var offList = allTypes.Except(types).Select(s => (int)s).ToList();

            var request = new SetPushConfigRequest
            {
                CallbackUrl = callBackUrl,
                PushConfigOnList = onList,
                PushConfigOffList = offList
            };

            return TryPostAsync(patch, request);
        }
    }
}
