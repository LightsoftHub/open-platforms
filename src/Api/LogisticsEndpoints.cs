using Light.Shopee;
using Microsoft.AspNetCore.Mvc;

namespace Api;

public static class LogisticsEndpoints
{
    public static void MapLogisticsEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/logistics/get_address_list", (ILogisticsClient client) =>
            {
                return client.GetAddressList();
            })
            .WithName("GetAddressList");

        endpoint
            .MapGet("/logistics/{ordersn}/shipping_parameter", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetShippingParameter(ordersn);
            })
            .WithName("GetShippingParameter");

        endpoint
            .MapGet("/logistics/{ordersn}/tracking_number", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetTrackingNumber(ordersn);
            })
            .WithName("GetTrackingNumber");

        endpoint
            .MapGet("/logistics/{ordersn}/tracking_info", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.GetTrackingInfo(ordersn);
            })
            .WithName("GetTrackingInfo");

        endpoint
            .MapGet("/logistics/{ordersn}/download_awb", ([FromRoute] string ordersn, ILogisticsClient client) =>
            {
                return client.DownloadShippingDocument([ordersn]);
            })
            .WithName("GetAWB");
    }
}
