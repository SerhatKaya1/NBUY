using YemekTarifiApp.Business.Abstract;
using YemekTarifiApp.Business.Concrate;
using YemekTarifiApp.Data.Abstract;
using YemekTarifiApp.Data.Concrete;
using YemekTarifiApp.Data.Concrete.EfCore.Contexts;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YemekTarifiAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IFoodService, FoodManager>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "foods",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "YemekTarifi", action = "FoodList" }
    );

app.MapControllerRoute(
    name: "fooddetails",
    pattern: "yemekler/{foodurl}",
    defaults: new { controller = "YemekTarifi", action = "FoodDetails" }
    );

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
