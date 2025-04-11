using Light.Shopee;

namespace Api.Shopee;

public static class PublicEndpoints
{
    public static void MapPublicEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/public/get_ip_ranges", (IPublicClient client) =>
            {
                return client.GetShopeeIpRanges();
            })
            .WithName("GetIpRanges");
    }
}
