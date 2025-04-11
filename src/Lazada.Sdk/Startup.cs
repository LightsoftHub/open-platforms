using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Light.Lazada
{
    public static class Startup
    {
        private const string HTTP_CLIENT_NAME = "LazadaApi";

        public static HttpClient CreateLazClient(this IHttpClientFactory httpClientFactory)
        {
            return httpClientFactory.CreateClient(HTTP_CLIENT_NAME);
        }

        public static IServiceCollection AddLazadaHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient(HTTP_CLIENT_NAME);

            return services;
        }

        public static IServiceCollection AddLazadaAPI(this IServiceCollection services)
        {
            services.AddScoped<IAuthClient, AuthClient>();

            services.AddScoped<IOrderClient, OrderClient>();
            services.AddScoped<IProductClient, ProductClient>();
            services.AddScoped<IFulfillmentClient, FulfillmentClient>();

            return services;
        }
    }
}
