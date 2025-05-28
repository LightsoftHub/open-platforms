using Light.GrabSdk.GrabExpress;
using Light.GrabSdk.GrabExpress.Delivery;
using Light.GrabSdk.GrabExpress.DeliveryQuotes;
using Light.Tiki.Models.Orders;
using Microsoft.AspNetCore.Mvc;

namespace Api.GrabExpress;

public static class DependencyInjection
{
    public static void AddGrabExpress(this IServiceCollection services)
    {
        services.AddScoped<IGrabExpressCredential, CredentialProvider>();

        services.AddGrabExpressHttpClient("https://partner-api.grab.com");
        services.AddGrabExpressAPI();
    }

    public static void MapGrabExpress(this IEndpointRouteBuilder endpoint)
    {
        var group = endpoint.MapGroup("grabexpress");

        group
            .MapPost("deliveries/quotes", (
                GetDeliveryQuotesRequest request,
                IDeliveryClient deliveryClient) =>
            {
                return deliveryClient.GetDeliveryQuotes(request);
            });

        group
            .MapPost("deliveries", (
                CreateDeliveryRequest request,
                IDeliveryClient deliveryClient) =>
            {
                return deliveryClient.CreateDeliveryRequest(request);
            });

        group
            .MapGet("deliveries/{deliveryID}", (
                [FromRoute] string deliveryID,
                IDeliveryClient deliveryClient) =>
            {
                return deliveryClient.GetDeliveryDetails(deliveryID);
            });

        group
            .MapDelete("deliveries/{deliveryID}", (
                [FromRoute] string deliveryID,
                IDeliveryClient deliveryClient) =>
            {
                return deliveryClient.CancelDelivery(deliveryID);
            });

        group
            .MapDelete("merchant/deliveries/{merchantOrderID}", (
                [FromRoute] string merchantOrderID,
                IDeliveryClient deliveryClient) =>
            {
                return deliveryClient.CancelDeliveryByMerchantOrderID(merchantOrderID);
            });
    }
}
