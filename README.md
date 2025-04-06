# Shopee API Reference v2

- [x] Signed & Auth
- [x] Product
- [x] Shop
- [x] Order
- [x] Logistics
- [x] Payment
- [ ] Discount
- [x] Return
- [ ] Ads
- [x] Public
- [x] Push

Please implement interface IShopeeCredential and inject before use services:
```
public class ShopeeCredentialProvider : IShopeeCredential
{
    public Task<ShopeeApiCredential> GetCredential()
    {
        var result = new ShopeeApiCredential(
            "https://partner.shopeemobile.com",
            0,
            0,
            "<your_secret_key>",
            "your_access_token");

        return Task.FromResult(result);
    }
}
```

 
