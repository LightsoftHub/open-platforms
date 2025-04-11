using Light.Lazada.Common;
using Light.Lazada.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public class OrderClient : LazadaHttpClient, IOrderClient
    {
        public OrderClient(IHttpClientFactory httpClientFactory, ILazadaCredential provider) : base(httpClientFactory, provider)
        {
        }

        public async Task<LazResult<OrdersList>> GetOrders(int offset = 0, int limit = 100,
            DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null,
            DateTimeOffset? updateAfter = null, DateTimeOffset? updateBefore = null)
        {
            var path = "/orders/get";
            var request = new Dictionary<string, string>()
            {
                { "offset", offset.ToString() },
                { "limit", limit.ToString() },
            };

            if (createdAfter.HasValue) // create from
                request.Add("created_after", createdAfter.ToLazDate());

            if (createdAfter.HasValue) // create to
                request.Add("created_before", createdBefore.ToLazDate());

            if (updateAfter.HasValue) // update from
                request.Add("update_after", updateAfter.ToLazDate());

            if (updateAfter.HasValue) // update to
                request.Add("update_before", updateBefore.ToLazDate());

            var response = await TryGetAsync(path, request);

            var result = await response.ReadData<OrdersList>();

            return result;
        }

        public async Task<LazResult<Order>> GetOrder(string orderId)
        {
            var path = "/order/get";
            var request = new Dictionary<string, string>()
            {
                { "order_id", orderId },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.ReadData<Order>();

            return result;
        }

        public async Task<LazResult<IEnumerable<OrderItem>>> GetOrderItems(string orderId)
        {
            var path = "/order/items/get";
            var request = new Dictionary<string, string>()
            {
                { "order_id", orderId },
            };

            var response = await TryGetAsync(path, request);

            var result = await response.ReadData<IEnumerable<OrderItem>>();

            return result;
        }

        public async Task<object> GetShippingLabel(IEnumerable<string> orderItemIds)
        {
            var path = "/order/document/get";

            var orderItems = orderItemIds.Join();

            var request = new Dictionary<string, string>()
            {
                { "doc_type", "shippingLabel" },
                { "order_item_ids", $"[{orderItems}]" },
            };

            var response = await TryGetAsync(path, request);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
