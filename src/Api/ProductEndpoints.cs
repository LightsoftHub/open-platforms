using Light.Shopee;
using Light.Shopee.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace Api;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/categories", (IProductClient client) =>
            {
                return client.GetCategories();
            })
            .WithName("GetCategories");

        endpoint
            .MapGet("/products", (IProductClient client) =>
            {
                return client.GetItemList(new GetProductListRequest());
            })
            .WithName("GetProducts");

        endpoint
            .MapGet("/product/{id}", ([FromRoute] long id, IProductClient client) =>
            {
                return client.GetItemBaseInfo(new([id]));
            })
            .WithName("GetProduct");

        endpoint
            .MapGet("/product/{id}/models", ([FromRoute] long id, IProductClient client) =>
            {
                return client.GetModelList(id);
            })
            .WithName("GetProductModels");
    }
}
