using Light.Shopee.Enums;
using System;

namespace Light.Shopee.Models.Order
{
    public class GetOrderListRequest : BaseRequest
    {
        public GetOrderListRequest(DateTime time_from, DateTime time_to, bool by_create_time = false)
        {
            Add("time_range_field", by_create_time ? "create_time" : "update_time");
            Add(() => time_from);
            Add(() => time_to);
            Add("response_optional_fields", "order_status");

            SetIndex("");
        }

        public void SetIndex(string cursor, int page_size = 40)
        {
            Add(() => cursor);
            Add(() => page_size);
        }

        public void ByStatus(OrderStatus order_status) => Add(() => order_status);
    }
}
