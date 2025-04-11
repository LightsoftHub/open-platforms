using Light.Tiki;
using Microsoft.AspNetCore.Mvc;

namespace Api.Tiki;

public static class TikiEndpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/order/{orderCode}", ([FromRoute] string orderCode, IOrderClient orderClient) =>
            {
                return orderClient.GetOrderDetails(orderCode);
            });
    }
}
