using Microsoft.EntityFrameworkCore;
using OnlineShop.Api.Data;

var builder = WebApplication.CreateBuilder(args);


// Use OnlineSHopDBContext class for Dependency Injection while migrating and also uses the connection string.
builder.Services.AddDbContextPool<OnlineShopDbContext>(options =>options.UseSqlServer
    (builder.Configuration.GetConnectionString("OnlineShopConnection")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
