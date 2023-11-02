using Microsoft.EntityFrameworkCore;
using PS.All_Films.Web.BusinessLogic.Interfaces;
using PS.All_Films.Web.BusinessLogic.Repositories;
using PS.All_Films.Web.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IMovie, MovieRepository>();

builder.Services.AddDbContext<ApplicationContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();


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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
