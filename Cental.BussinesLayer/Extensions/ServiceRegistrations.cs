using Cental.BussinesLayer.Abstract;
using Cental.BussinesLayer.Concrete;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Extensions
{
    public static class ServiceRegistrations
    {
        //IOC Container
        public static void AddServiceRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IBannerService, BannerManager>();
            services.AddScoped<IBannerDal, EfBannerDal>();

            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBranDal, EfBrandDal>();

            services.AddScoped<ICarService, CarManager>();
            services.AddScoped<ICarDal, EfCarDal>();

            services.AddScoped<IImageService, ImageService>();

            services.AddScoped<IUserSocialService, UserSocialManager>();
            services.AddScoped<IUserSocialDal, EfuserSocialDal>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();

            services.AddScoped<IServicesService, ServicesManager>();
            services.AddScoped<IServiceDal, EfServiceDal>();

            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IBookingDal, EfBookingDal>();

            services.AddScoped<IProcessService, ProcessManager>();
            services.AddScoped<IProcessDal, EfProcessDal>();
        }
    }
}
