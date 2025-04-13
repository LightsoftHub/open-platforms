using Light.GrabMart;
using Microsoft.AspNetCore.Mvc;

namespace Api.GrabMart;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/{merchandId}/orders/", ([FromRoute] string merchandId, IOrderClient orderClient) =>
            {
                return orderClient.GetOrderList(merchandId, DateTime.Today, 1);
            });

        endpoint
            .MapGet("/order/update", (IOrderClient orderClient) =>
            {
                return orderClient.Update(new()
                {
                    OrderID = "test_id"
                });
            });
    }
}
