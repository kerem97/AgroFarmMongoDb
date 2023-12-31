
using AgroFarmMongoDb.Services.About;
using AgroFarmMongoDb.Services.Banner;
using AgroFarmMongoDb.Services.Statistic;
using AgroFarmMongoDb.Services.Testimonial;
using AgroFarmMongoDb.Services.VideoPopup;
using AgroFarmMongoDb.Services.WhatWeDo;
using AgroFarmMongoDb.Services.WhyUs;
using AgroFarmMongoDb.Settings;
using Microsoft.Extensions.Options;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IWhatWeDoService, WhatWeDoService>();
builder.Services.AddScoped<IVideoPopupService, VideoPopupService>();
builder.Services.AddScoped<IWhyUsService, WhyUsService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();


builder.Services.AddSingleton<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
});



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
