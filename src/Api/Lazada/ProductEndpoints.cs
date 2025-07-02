using Light.Lazada;
using Microsoft.AspNetCore.Mvc;

namespace Api.Lazada;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/products", (IProductClient client) =>
            {
                return client.GetProducts();
            });

        endpoint
            .MapGet("/product/{itemId}", ([FromRoute] string itemId, IProductClient client) =>
            {
                return client.GetProductItem(itemId);
            });
    }
}
