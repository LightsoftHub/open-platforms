# Lazada API Reference

- [x] Signed & Auth
- [x] Product
- [x] Order
- [x] Fulfillment

Please implement interface ILazadaCredential and inject before use services:
```
public class CredentialProvider : ILazadaCredential
{
    public Task<LazadaApiCredential> GetCredential()
    {
        var result = new LazadaApiCredential()
        {
            BaseUrl = "",
            AppKey = "",
            AppSecret = "",
            AccessToken = "",
        };

        return Task.FromResult(result);
    }
}
```

Add & custom HttpClientBuilder
```
builder.Services.AddLazadaHttpClient();
```

Add API services
```
builder.Services.AddLazadaAPI();
```

 
