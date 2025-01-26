using Cental.BussinesLayer.Abstract;
using Cental.BussinesLayer.Concrete;
using Cental.BussinesLayer.Extensions;
using Cental.BussinesLayer.Validators.BrandValidators;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concrete;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using Cental.EntityLayer.Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// About service g�rd���n zaman about manager s�n�f�ndan bir nesne �rne�i al ve i�lemi onunla yap.
builder.Services.AddDbContext<CentalContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<CentalContext>();
//auto mapper konfigrasyonu Web UI i�in. Businneste olsayd� farkl� olurdu.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//fluent apinin projeye dahil edilmesi. �lgili validator dosyan�n bulunmas� //post i�lemi yapmadan �nce kontrol etmesi i�in clientsadapters ekleniyor.
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
