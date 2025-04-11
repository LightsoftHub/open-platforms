using Light.Contracts;
using Light.Tiki.Models.Orders;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public class OrderApiClient : TikiHttpClient, IOrderClient
    {
        public OrderApiClient(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<Result<OrderList>> GetOrderList(DateTime? updatedFromDate, DateTime? updatedToDate, int page = 1)
        {
            var url = "integration/v2/orders";
            url += $"?page={page}&limit=50";

            if (updatedFromDate != null)
            {
                url += $"&updated_from_date={updatedFromDate:yyyy-MM-dd HH:mm:ss}";
            }

            if (updatedToDate != null)
            {
                url += $"&updated_to_date={updatedToDate:yyyy-MM-dd HH:mm:ss}";
            }

            return await TryGetAsync<OrderList>(url);
        }

        public async Task<Result<Order>> GetOrderDetails(string orderId)
        {
            var url = $"integration/v2/orders/{orderId}";
            // Include-able fields: status_histories, item.fees, item.confirmation_histories
            url += "?include=status_histories,item.fees,item.confirmation_histories";

            return await TryGetAsync<Order>(url);
        }

        public async Task<Result<ExpectedPickupTime>> GetExpectedPickupTimes()
        {
            var url = "integration/v2/orders/dropship/expected-pickup-slots";

            return await TryGetAsync<ExpectedPickupTime>(url);
        }

        public async Task<Result> ConfirmEnoughStockForDropShipping(string orderCode, bool accept, long sellerInventoryId, string expectedPickupTime)
        {
            var url = $"integration/v2/orders/{orderCode}/dropship/confirm-available";

            var request = new
            {
                confirmation_status = accept ? "seller_confirmed" : "seller_canceled",
                seller_inventory_id = sellerInventoryId,
                expected_pickup_time = expectedPickupTime
            };

            return await TryPostAsync(url, request);
        }

        public async Task<Result<ShippingStamp>> GetShippingStamp(string orderCode)
        {
            var url = $"integration/v2/orders/{orderCode}/dropship/labels";

            return await TryGetAsync<ShippingStamp>(url);
        }
    }
}
