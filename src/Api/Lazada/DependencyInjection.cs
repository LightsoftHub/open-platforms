using Light.Lazada;

namespace Api.Lazada;

public static class DependencyInjection
{
    public static void AddLazada(this IServiceCollection services)
    {
        services.AddScoped<ILazadaCredential, LazadaCredentialProvider>();

        services.AddLazadaHttpClient();
        services.AddLazadaAPI();
    }

    public static void MapLazada(this IEndpointRouteBuilder endpoint)
    {
        var group = endpoint.MapGroup("lazada");

        group.MapProductEndpoints();
        group.MapOrderEndpoints();
    }
}
