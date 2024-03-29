﻿using MangoWeb;
using MangoWeb.Services;
using MangoWeb.Services.IServices;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
// TODO: Remove this .AddRazorRuntimeCompilation(); when FE finish
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddHttpClient<IProductService, ProductService>();
SD.ProductAPIBase = configuration["ServiceUrls:ProductAPI"];
builder.Services.AddScoped<IProductService, ProductService>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

