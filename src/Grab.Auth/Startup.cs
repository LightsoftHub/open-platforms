using Microsoft.Extensions.DependencyInjection;
using System;

namespace Light.Grab.Auth
{
    public static class Startup
    {
        public static IHttpClientBuilder AddGrabAuthHttpClient(this IServiceCollection services, string baseAddress)
        {
            return services
                .AddHttpClient<GrabAuthClient>("GrabAuth", client =>
                {
                    client.BaseAddress = new Uri(baseAddress);
                });
        }
    }
}