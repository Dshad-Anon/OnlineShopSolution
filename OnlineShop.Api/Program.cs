using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using OnlineShop.Api.Data;
using OnlineShop.Api.Repositories;
using OnlineShop.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);


// Use OnlineSHopDBContext class for Dependency Injection while migrating and also uses the connection string.
builder.Services.AddDbContextPool<OnlineShopDbContext>(options =>options.UseSqlServer
    (builder.Configuration.GetConnectionString("OnlineShopConnection")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
policy.WithOrigins("https://localhost:7142", "http://localhost:7142")
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
