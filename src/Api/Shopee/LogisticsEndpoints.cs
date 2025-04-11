using Light.Shopee;
using Microsoft.AspNetCore.Mvc;

namespace Api.Shopee;

public static class LogisticsEndpoints
{
    public static void MapLogisticsEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/logistics/get_address_list", (ILogisticsClient client) =>
            {
                return client.GetAddressList();
            });

        endpoint
            .MapGet("/logistics/{ordersn}/shipping_parameter", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetShippingParameter(ordersn);
            });

        endpoint
            .MapGet("/logistics/{ordersn}/tracking_number", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetTrackingNumber(ordersn);
            });

        endpoint
            .MapGet("/logistics/{ordersn}/tracking_info", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetTrackingInfo(ordersn);
            });

        endpoint
            .MapGet("/logistics/{ordersn}/download_awb", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.DownloadShippingDocument([ordersn]);
            });
    }
}
