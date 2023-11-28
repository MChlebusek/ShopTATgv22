using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Shop.ApplicationServices.Services;
using Shop.Core.Domain;
using Shop.Core.ServiceInterface;
using Shop.Data;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//add dependence interface and service class
builder.Services.AddScoped<ISpaceshipServices, SpaceshipServices>();
//add dependence interface and service class
builder.Services.AddScoped<IFileServices, FileServices>();

//add dependence interface and service class
builder.Services.AddScoped<IRealEstateServices, RealEstatesServices>();
//add dependence interface and service class
builder.Services.AddScoped<IKindergartenServices, KinderGartenServices>();

builder.Services.AddScoped<IWeatherForecastServices, WeatherForecastServices>();

builder.Services.AddScoped<IChuckNorrisServices, ChuckNorrisServices>();

builder.Services.AddScoped<ICocktailServices, CocktailServices>();

builder.Services.AddScoped<IAccuWeatherServices, AccuWeatherServices>();



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//for display pictures in details
app.UseStaticFiles(new StaticFileOptions
   {
    FileProvider=new PhysicalFileProvider

    (Path.Combine(builder.Environment.ContentRootPath, "multipleFileUpload")),
    RequestPath="/multipleFileUpload"



    });

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


