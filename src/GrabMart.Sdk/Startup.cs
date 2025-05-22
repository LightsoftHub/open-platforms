using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Light.GrabMart
{
    public static class Startup
    {
        private const string GRABMART_AUTH_CLIENT_NAME = "GrabMartAuth";

        private const string GRABMART_CLIENT_NAME = "GrabMartApi";

        public static HttpClient CreateGrabMartClient(this IHttpClientFactory httpClientFactory)
            => httpClientFactory.CreateClient(GRABMART_CLIENT_NAME);

        public static HttpClient CreateGrabMartAuthClient(this IHttpClientFactory httpClientFactory)
            => httpClientFactory.CreateClient(GRABMART_AUTH_CLIENT_NAME);

        public static IHttpClientBuilder AddGrabMartAuthHttpClient(this IServiceCollection services, string baseAddress = "https://api.grab.com")
        {
            return services
                .AddHttpClient(GRABMART_AUTH_CLIENT_NAME, client =>
                {
                    client.BaseAddress = new Uri(baseAddress);
                });
        }

        public static IHttpClientBuilder AddGrabMartHttpClient(this IServiceCollection services, string baseAddress = "https://partner-api.grab.com")
        {
            return services
                .AddTransient<GrabMartApiHandler>()
                .AddHttpClient(GRABMART_CLIENT_NAME, client =>
                {
                    client.BaseAddress = new Uri(baseAddress);
                })
                .AddHttpMessageHandler<GrabMartApiHandler>();
        }

        public static IServiceCollection AddGrabAPI(this IServiceCollection services)
        {
            services.AddScoped<IAuthClient, AuthClient>();

            services.AddScoped<IMenuClient, MenuClient>();
            services.AddScoped<IOrderClient, OrderClient>();
            services.AddScoped<ICampaignClient, CampaignClient>();

            return services;
        }
    }
}