using Light.Lazada;

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
            .MapGet("/product/{sellerSku}", (string sellerSku, IProductClient client) =>
            {
                return client.GetProductItem(sellerSku);
            });
    }
}
