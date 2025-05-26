using Light.Grab.Auth;
using Light.GrabMart;

namespace Api.GrabMart;

public static class DependencyInjection
{
    public static void AddGrabMart(this IServiceCollection services)
    {
        services.AddScoped<IGrabMartCredential, CredentialProvider>();

        services.AddGrabAuthHttpClient("");
        services.AddGrabMartHttpClient();
        services.AddGrabAPI();
    }

    public static void MapGrabMart(this IEndpointRouteBuilder endpoint)
    {
        var group = endpoint.MapGroup("grabmart");

        group.MapOrderEndpoints();
    }
}
