using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ecommerce.DAL.Helper;
using Ecommerce.BLL.Services.UserServices;
using Ecommerce.BLL.Services.Category_Services;
using Ecommerce.DAL.Repository.CategoryRepository;
using Ecommerce.DAL.Repository.Category_Repository;
using Ecommerce.Data.Models;
using Microsoft.EntityFrameworkCore; // Update the namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configuration
//var configuration = builder.Configuration;
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
builder.Services.AddDbContext<EcommerceContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("ECommerceConnection")));
// Register your ECommerceDbHelper with the connection string injected
string connectionString = configuration.GetConnectionString("ECommerceConnection");
builder.Services.AddSingleton(new ECommerceDbHelper(connectionString));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
// Add IUserService implementation
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SignIn}/{action=Signin}/{id?}");

app.Run();
