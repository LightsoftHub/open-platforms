using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Light.Tiki
{
    public static class Startup
    {
        private const string HTTP_CLIENT_NAME = "TikiApi";

        internal static HttpClient CreateTikiClient(this IHttpClientFactory httpClientFactory) =>
            httpClientFactory.CreateClient(HTTP_CLIENT_NAME);

        public static void AddTikiHttpClient(this IServiceCollection services, string baseAddress = "https://api.tiki.vn")
        {
            services
                .AddTransient<TikiAuthHeaderClientHandler>()
                .AddHttpClient(HTTP_CLIENT_NAME, client =>
                {
                    client.BaseAddress = new Uri(baseAddress);
                })
                .AddHttpMessageHandler<TikiAuthHeaderClientHandler>();
        }

        public static IServiceCollection AddTikiAPI(this IServiceCollection services)
        {
            services.AddScoped<IAuthClient, AuthApiClient>();
            services.AddScoped<IProductClient, ProductApiClient>();
            services.AddScoped<IOrderClient, OrderApiClient>();

            return services;
        }
    }
}