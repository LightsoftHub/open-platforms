using Light.Shopee.Models;
using Light.Shopee.Models.Payment;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class PaymentClient : ShopeeHttpClient, IPaymentClient
    {
        public PaymentClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameterProvider) : base(httpClientFactory, parameterProvider)
        {
        }

        public Task<IShopeeResult<EscrowDetailResponse>> GetEscrowDetail(string order_sn) =>
            TryGetAsync<EscrowDetailResponse>("/api/v2/payment/get_escrow_detail",
                BaseRequest.Create(() => order_sn));

        public Task<string> GetEscrowUrl(string order_sn) =>
            BuildSignedUrl("/api/v2/payment/get_escrow_detail",
                BaseRequest.Create(() => order_sn));

        public Task<IShopeeResult<EscrowListResponse>> GetEscrowList(DateTime from, DateTime to)
        {
            var request = new BaseRequest();
            request.Add("release_time_from", from);
            request.Add("release_time_to", to);

            return TryGetAsync<EscrowListResponse>("/api/v2/payment/get_escrow_list", request);
        }
    }
}

