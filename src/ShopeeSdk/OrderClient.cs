using Light.Shopee.Models;
using Light.Shopee.Models.Order;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Shopee
{
    internal class OrderClient : ShopeeHttpClient, IOrderClient
    {
        public OrderClient(IHttpClientFactory httpClientFactory, IShopeeCredential parameters) : base(httpClientFactory, parameters)
        {
        }

        /// inherit docs
        public Task<IShopeeResult<OrderListResponse>> GetOrderList(GetOrderListRequest request) =>
            TryGetAsync<OrderListResponse>("/api/v2/order/get_order_list", request);

        /// inherit docs
        public Task<IShopeeResult<OrdersDetailsResponse>> GetOrderDetails(string[] order_sn_list) =>
            TryGetAsync<OrdersDetailsResponse>("/api/v2/order/get_order_detail",
                new GetOrderDetailsRequest(order_sn_list));

        /// inherit docs
        public Task<string> GetOrderSignedUrl(string ordersn) =>
            BuildSignedUrl("/api/v2/order/get_order_detail",
                new GetOrderDetailsRequest(new string[] { ordersn }));

        public Task<IShopeeResult<HandleBuyerCancellationResponse>> HandleBuyerCancellation(string ordersn, bool accept)
        {
            var patch = "/api/v2/order/handle_buyer_cancellation";

            string handle = accept ? "ACCEPT" : "REJECT";

            var request = new
            {
                order_sn = ordersn,
                operation = handle
            };

            return TryPostAsync<HandleBuyerCancellationResponse>(patch, request);
        }
    }
}