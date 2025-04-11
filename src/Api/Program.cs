using Api.Lazada;
using Api.Shopee;
using Api.Tiki;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Open Platforms API
builder.Services.AddShopee();
builder.Services.AddLazada();
builder.Services.AddTiki();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Open Platforms API
app.MapShopee();
app.MapLazada();
app.MapTiki();

app.Run();