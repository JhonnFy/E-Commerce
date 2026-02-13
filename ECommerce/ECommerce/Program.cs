
/*Asignar Valores*/
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using ECommerce.Context;
using ECommerce.Repositories;
using ECommerce.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/*Clase Que Contiene La Cadena*/
builder.Services.AddDbContext<AppDbContext>(options =>
{
    //InvocarLaCadena
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));
});

builder.Services.AddScoped(typeof(GenericRepository<>)); /*Espera Una Entidad*/
builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<ProductServices>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<UserService>();

//Temporal De Usuario
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30);});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options =>
    {
        options.LoginPath = "/Account/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

        options.AccessDeniedPath = "/Home/Error";

    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
