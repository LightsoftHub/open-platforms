using Light.Contracts;
using Light.Tiki.Models.Orders;
using System;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public interface IOrderClient
    {
        // https://open.tiki.vn/docs/docs/current/api-references/order-api-v2/#order-listing-v2
        Task<Result<OrderList>> GetOrderList(DateTime? updatedFromDate, DateTime? updatedToDate, int page = 1);

        // https://open.tiki.vn/docs/docs/current/api-references/order-api-v2/#order-details-v2
        Task<Result<Order>> GetOrderDetails(string orderCode);

        // https://open.tiki.vn/docs/docs/current/api-references/order-api-v2/#get-expected-pickup-times
        Task<Result<ExpectedPickupTime>> GetExpectedPickupTimes();

        // https://open.tiki.vn/docs/docs/current/api-references/order-api-v2/#confirm-enough-stock-for-drop-shipping
        Task<Result> ConfirmEnoughStockForDropShipping(string orderCode, bool accept, long sellerInventoryId, string expectedPickupTime);

        // https://open.tiki.vn/docs/docs/current/api-references/order-api-v2/#get-shipping-stamp-for-dropship
        Task<Result<ShippingStamp>> GetShippingStamp(string orderCode);
    }
}
