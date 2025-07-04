using Light.Lazada;
using Microsoft.AspNetCore.Mvc;

namespace Api.Lazada;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/orders", (IOrderClient orderClient) =>
            {
                return orderClient.GetOrders();
            });

        endpoint
            .MapGet("/order/{orderid}", ([FromRoute] string orderid, IOrderClient orderClient) =>
            {
                return orderClient.GetOrder(orderid);
            });

        endpoint
            .MapPost("/order/get_document", ([FromBody] string[] orderItemIds, IOrderClient orderClient) =>
            {
                return orderClient.GetDocument(orderItemIds);
            });

        endpoint
            .MapPost("/fulfillment/get_shipment_provider/{orderid}", ([FromRoute] string orderid, [FromBody] string[] orderItemIds, IFulfillmentClient client) =>
            {
                return client.GetShipmentProvider(orderid, orderItemIds);
            });

        endpoint
            .MapGet("/fulfillment/print_awb/{packageId}", ([FromRoute] string packageId, IFulfillmentClient client) =>
            {
                return client.PrintAWB(packageId);
            });
    }
}
