namespace Light.Lazada.Models.Products
{
    public class UploadStockRequest
    {
        public UploadStockRequest(long itemId, long skuId, string sellerSku, int stock)
        {
            string request = "<Request>";
            request += "<Product>";
            request += "<Skus>";

            request += "<Sku>";
            request += $"<ItemId>{itemId}</ItemId>";
            request += $"<SkuId>{skuId}</SkuId>";
            request += $"<SellerSku>{sellerSku}</SellerSku>";
            request += $"<SellableQuantity>{stock}</SellableQuantity>";
            request += "</Sku>";

            request += "</Skus>";
            request += "</Product>";
            request += "</Request>";

            Payload = request;
        }

        public string Payload { get; private set; }
    }
}
