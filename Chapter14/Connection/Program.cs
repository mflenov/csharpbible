using System.Reflection;
using Microsoft.AspNetCore.Builder;
using MyWebSite.Model.Interfaces;
using MyWebSite.Model.Implementation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();

builder.Services.AddScoped<IDbConnection, DbConnection>();
builder.Services.AddScoped<ICityProvider, CityProvider>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();

//app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//        name: "Test",
//        pattern: "my/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
     name: "default",
     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
