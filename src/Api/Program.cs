using Api;
using Light.Shopee;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IShopeeCredential, ShopeeCredentialProvider>();

builder.Services.AddShopeeHttpClient();
builder.Services.AddShopeeAPIv2();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapProductEndpoints();
app.MapOrderEndpoints();
app.MapPaymentEndpoints();
app.MapReturnEndpoints();
app.MapLogisticsEndpoints();
app.MapPublicEndpoints();

app.Run();