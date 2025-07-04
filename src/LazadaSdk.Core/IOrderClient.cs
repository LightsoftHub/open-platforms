using Light.Lazada.Common;
using Light.Lazada.Models.Orders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public interface IOrderClient
    {
        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fdocument%2Fget
        Task<ILazResponse<OrderDocument>> GetDocument(IEnumerable<string> orderItemIds);

        // https://open.lazada.com/apps/doc/api?path=%2Forders%2Fget
        Task<ILazResponse<OrdersList>> GetOrders(int offset = 0, int limit = 100,
            DateTimeOffset? createdAfter = null, DateTimeOffset? createdBefore = null,
            DateTimeOffset? updateAfter = null, DateTimeOffset? updateBefore = null);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fget
        Task<ILazResponse<Order>> GetOrder(string orderId);

        // https://open.lazada.com/apps/doc/api?path=%2Forder%2Fitems%2Fget
        Task<ILazResponse<IEnumerable<OrderItem>>> GetOrderItems(string orderId);
    }
}
