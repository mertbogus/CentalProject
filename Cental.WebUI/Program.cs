using Cental.BussinesLayer.Abstract;
using Cental.BussinesLayer.Concrete;
using Cental.BussinesLayer.Extensions;
using Cental.BussinesLayer.Validators;
using Cental.BussinesLayer.Validators.BrandValidators;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concrete;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using Cental.EntityLayer.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Net;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<CentalContext>();

builder.Services.AddIdentity<AppUser, AppRole>(cfg =>
{
    //ayný email ile kaydýn önüne geçmek için.
    cfg.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<CentalContext>()
    .AddErrorDescriber<CustomErrorDescriber>();

//auto mapper konfigrasyonu Web UI için. Businneste olsaydý farklý olurdu.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//fluent apinin projeye dahil edilmesi. Ýlgili validator dosyanýn bulunmasý //post iþlemi yapmadan önce kontrol etmesi için clientsadapters ekleniyor.
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters().AddValidatorsFromAssemblyContaining<CreateBrandValidator>();
builder.Services.AddServiceRegistrations();
// Add services to the container.
builder.Services.AddControllersWithViews(option =>
{
    option.Filters.Add(new AuthorizeFilter());
});

builder.Services.ConfigureApplicationCookie(cfg =>
{
    //Authenticatio yaptýðýmýz yere giderken otomatik bir sayfaya yönlendiriyordu. Ýstediðimiz sayfaya yönlendirdik.
    cfg.LoginPath = "/Login/Index";
    cfg.LogoutPath = "/Login/LogOut";
    cfg.AccessDeniedPath = "/ErrorPage/AccessDenied";
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
app.UseStatusCodePagesWithReExecute("/ErrorPage/NotFound404");
app.UseRouting();

app.UseAuthentication(); //sistemde kayýtlý mý deðil mi
app.UseAuthorization(); //yetkisi var mý?

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
  name: "areas",
  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
