using Light.Contracts;
using Light.GrabMart.Models.Orders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Light.GrabMart
{
    public interface IOrderClient
    {
        Task<OrderList> GetOrderList(string merchantId, DateTime date, int page);
        Task<List<Order>> GetAllOrders(string merchantId, DateTime date);
        Task<Order> FindOrder(string merchantId, DateTime date, string orderId);
        Task<Result> Manual(string orderId, bool isAccept);
        Task<Result> Update(UpdateOrder request);
        Task<CheckOrderCancelable> CheckOrderCancelable(string merchantId, string orderId);
        Task<Result> CancelOrder(string merchantId, string orderId, int cancelCode);
    }
}
