using Light.GrabMart;

namespace Api.GrabMart;

public static class DependencyInjection
{
    public static void AddGrabMart(this IServiceCollection services)
    {
        services.AddScoped<IGrabCredential, CredentialProvider>();

        services.AddGrabMartAuthHttpClient();
        services.AddGrabMartHttpClient();
        services.AddGrabAPI();
    }

    public static void MapGrabMart(this IEndpointRouteBuilder endpoint)
    {
        var group = endpoint.MapGroup("grabmart");

        group.MapOrderEndpoints();
    }
}
