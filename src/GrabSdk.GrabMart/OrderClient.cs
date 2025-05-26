using Light.Contracts;
using Light.GrabSdk.GrabMart.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.GrabSdk.GrabMart
{
    public class OrderClient : GrabMartHttpClient, IOrderClient
    {
        public OrderClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<OrderList> GetOrderList(string merchantId, DateTime date, int page)
        {
            var url = $"partner/v1/orders";
            url += $"?merchantID={merchantId}";
            url += $"&date={date:yyyy-MM-dd}";
            url += $"&page={page}";

            var response = await GetAsync(url);
            return await response.ReadObjAsync<OrderList>();
        }

        public async Task<List<Order>> GetAllOrders(string merchantId, DateTime date)
        {
            var result = new List<Order>();

            bool more;
            int page = 1;
            do
            {
                var apiOrder = await GetOrderList(merchantId, date, page);

                if (apiOrder != null && apiOrder.Orders != null)
                {
                    result.AddRange(apiOrder.Orders);
                    more = apiOrder.More;
                    page++;
                }
                else
                {
                    break;
                }
            }
            while (more);

            return result;
        }

        public async Task<Order> FindOrder(string merchantId, DateTime date, string orderId)
        {
            var orders = await GetAllOrders(merchantId, date);
            return orders.FirstOrDefault(x => x.OrderID == orderId);
        }

        public async Task<Result> Manual(string orderId, bool isAccept)
        {
            var url = $"partner/v1/order/prepare";
            var request = new
            {
                orderID = orderId,
                toState = isAccept ? "Accepted" : "Rejected"
            };

            var response = await PostAsJsonAsync(url, request);
            return await response.ToResultAsync();
        }

        public async Task<CheckOrderCancelable> CheckOrderCancelable(string merchantId, string orderId)
        {
            var url = $"partner/v1/order/cancelable";
            url += $"?merchantID={merchantId}";
            url += $"&orderID={orderId}";
            try
            {
                var response = await GetAsync(url);
                return await response.ReadObjAsync<CheckOrderCancelable>();
            }
            catch (Exception ex)
            {
                return new CheckOrderCancelable() { NonCancellationReason = ex.Message };
            }
        }

        public async Task<Result> CancelOrder(string merchantId, string orderId, int cancelCode)
        {
            var url = $"partner/v1/order/cancel";
            var request = new
            {
                orderID = orderId,
                merchantID = merchantId,
                cancelCode
            };

            var response = await PutAsJsonAsync(url, request);
            return await response.ToResultAsync();
        }

        public async Task<Result> Update(UpdateOrder request)
        {
            var url = $"partner/v1/order/{request.OrderID}/edit";

            var response = await PutAsJsonAsync(url, request);
            return await response.ToResultAsync();
        }
    }
}