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
    }
}
