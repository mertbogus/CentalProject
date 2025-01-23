using Cental.BussinesLayer.Abstract;
using Cental.BussinesLayer.Concrete;
using Cental.BussinesLayer.Extensions;
using Cental.BussinesLayer.Validators.BrandValidators;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concrete;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// About service gördüðün zaman about manager sýnýfýndan bir nesne örneði al ve iþlemi onunla yap.
builder.Services.AddDbContext<CentalContext>();

//auto mapper konfigrasyonu Web UI için. Businneste olsaydý farklý olurdu.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//fluent apinin projeye dahil edilmesi. Ýlgili validator dosyanýn bulunmasý //post iþlemi yapmadan önce kontrol etmesi için clientsadapters ekleniyor.
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters().AddValidatorsFromAssemblyContaining<CreateBrandValidator>();
builder.Services.AddServiceRegistrations();
// Add services to the container.
builder.Services.AddControllersWithViews();

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
