using System.ComponentModel;

namespace Light.Tiki.Enums
{
    public enum TikiOrder_Status
    {
        [Description("đơn hàng đang được xử lý")]
        processing,

        [Description("Tiki đã tiếp nhận đơn hàng và đang chờ nhà bán xác nhận")]
        queueing,

        [Description("Người bán đang chuẩn bị hàng")]
        picking,

        [Description("Đã hủy")]
        canceled,

        [Description("Đơn hàng đã hoàn thành")]
        complete,

        [Description("đơn hàng đã bàn giao đối tác")]
        handover_to_partner,

        [Description("shipper đang vận chuyển")]
        shipping,

        [Description("Giao hàng thành công")]
        successful_delivery,

        [Description("giao hàng thành công")]
        delivered,

        [Description("đơn hàng sẵn sàng được giao")]
        ready_to_ship,

        [Description("đơn hàng đã được trả")]
        returned,
    }
}