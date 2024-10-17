using MongoDB.Driver;
using ZTP01.Domain.Services;
using ZTP01.Domain.Interfaces;
using ZTP01.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

var mongoClient = new MongoClient(builder.Configuration.GetConnectionString("MongoDb"));
var database = mongoClient.GetDatabase("ProductDb");

builder.Services.AddSingleton(database);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();