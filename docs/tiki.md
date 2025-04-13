# TIKI API Reference

- [x] Signed & Auth
- [x] Product
- [x] Order

Please implement interface ITikiCredential and inject before use services:
```
public class CredentialProvider : ITikiCredential
{
    public async Task<string> GetAccessToken()
    {
        return <your_access_token>;
    }
}
```

Add & custom HttpClientBuilder
```
builder.Services.AddTikiHttpClient();
```

Add API services
```
builder.Services.AddTikiAPI();
```

 
