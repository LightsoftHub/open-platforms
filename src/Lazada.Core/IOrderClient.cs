using Light.Lazada.Common;
using Light.Lazada.Models.Orders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IOrderClient
    {
        // Get orders list
        Task<LazResult<OrdersList>> GetOrders(int offset = 0, int limit = 100,
            DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null,
            DateTimeOffset? updateAfter = null, DateTimeOffset? updateBefore = null);

        // Get order details
        Task<LazResult<Order>> GetOrder(string orderId);

        // Get items in order
        Task<LazResult<IEnumerable<OrderItem>>> GetOrderItems(string orderId);

        // Get Order document
        Task<object> GetShippingLabel(IEnumerable<string> orderItemIds);
    }
}
