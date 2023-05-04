using E2.Controllers;
using E2.Data;
using E2.Filters;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options => options.Filters.Add(new ExceptionFilter()));
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<E2DbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DB1")));
var app = builder.Build();
//builder.Services.AddExceptionHandler();
// Configure the HTTP request pipeline.
/*if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}*/
//Global error handling
//app.UseExceptionHandler("/Home/Error");
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Start}/{id?}");

app.Run();
