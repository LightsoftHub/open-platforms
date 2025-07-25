﻿using Light.Lazada;
using Light.Lazada.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace Api.Lazada;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this IEndpointRouteBuilder endpoint)
    {
        endpoint
            .MapGet("/products", (IProductClient client) =>
            {
                return client.GetProducts();
            });

        endpoint
            .MapGet("/product/{itemId}", ([FromRoute] string itemId, IProductClient client) =>
            {
                return client.GetProductItem(itemId);
            });

        endpoint
            .MapGet("/product/update_stock", (long itemId, long skuId, string sellerSku, int stock, IProductClient client) =>
            {
                return client.UpdateSellableQuantity(new UploadStockRequest(itemId, skuId, sellerSku, stock));
            });
    }
}
