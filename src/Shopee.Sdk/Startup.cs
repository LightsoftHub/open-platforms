using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Light.Shopee
{
    public static class Startup
    {
        private const string HTTP_CLIENT_NAME = "ShopeeApiReference";

        internal static HttpClient CreateShopeeClient(this IHttpClientFactory httpClientFactory) =>
            httpClientFactory.CreateClient(HTTP_CLIENT_NAME);

        public static IHttpClientBuilder AddShopeeHttpClient(this IServiceCollection services)
        {
            /*
            return services
                    .AddTransient<SignUrlHandler>()
                    .AddHttpClient(HTTP_CLIENT_NAME)
                    .AddHttpMessageHandler<SignUrlHandler>();
            */

            return services.AddHttpClient(HTTP_CLIENT_NAME);
        }

        public static IServiceCollection AddShopeeAPIv2(this IServiceCollection services)
        {
            services.AddScoped<IOrderClient, OrderClient>();
            services.AddScoped<IReturnsClient, ReturnsClient>();
            services.AddScoped<IProductClient, ProductClient>();
            services.AddScoped<ILogisticsClient, LogisticsClient>();
            services.AddScoped<IPaymentClient, PaymentClient>();
            services.AddScoped<IPushClient, PushClient>();
            services.AddScoped<IPublicClient, PublicClient>();
            services.AddScoped<IShopClient, ShopClient>();

            services.AddScoped<ITokenClient, TokenClient>();

            return services;
        }
    }
}