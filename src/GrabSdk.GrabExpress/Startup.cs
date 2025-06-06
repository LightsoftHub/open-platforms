﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace Light.Grab.GrabExpress
{
    public static class Startup
    {
        private const string GRABEXPRESS_CLIENT_NAME = "GrabExpressApi";

        public static HttpClient CreateGrabExpressClient(this IHttpClientFactory httpClientFactory)
            => httpClientFactory.CreateClient(GRABEXPRESS_CLIENT_NAME);

        public static IHttpClientBuilder AddGrabExpressHttpClient(this IServiceCollection services, string baseAddress)
        {
            return services
                .AddTransient<GrabExpressApiHandler>()
                .AddHttpClient(GRABEXPRESS_CLIENT_NAME, client =>
                {
                    client.BaseAddress = new Uri(baseAddress);
                })
                .AddHttpMessageHandler<GrabExpressApiHandler>();
        }

        public static IServiceCollection AddGrabExpressAPI(this IServiceCollection services)
        {
            services.AddScoped<IDeliveryClient, DeliveryClient>();
            services.AddScoped<IMultiStopDeliveryClient, MultiStopDeliveryClient>();

            return services;
        }
    }
}