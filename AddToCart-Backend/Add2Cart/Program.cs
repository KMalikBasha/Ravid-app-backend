using Add2Cart.Db_Context;
using Add2Cart.Services;
using Add2Cart.Interface;
using Add2Cart.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IServiceCollection serviceCollection = builder.Services.AddDbContext<DataBase>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultCS")
        );
});



builder.Services.AddControllers();
builder.Services.AddScoped<ICategory, CategoryService>();
builder.Services.AddScoped<Iproducts, ProductClass>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opt =>
{
opt.AddPolicy(name: "CorsPolicy", builder =>
{
builder.WithOrigins("https://dev-angular-app.azurewebsites.net")
.AllowAnyHeader()
.AllowAnyMethod();
});
});
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
if (app.Environment.IsDevelopment())
{
app.UseSwaggerUI();
}
if (!app.Environment.IsDevelopment())
{
app.UseSwaggerUI(options =>
{
options.SwaggerEndpoint("/swagger/v1/swagger.json","v1");
options.RoutePrefix = string.Empty;
});
}
