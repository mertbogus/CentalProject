﻿using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Context
{
    public class CentalContext:IdentityDbContext<AppUser,AppRole,int>
    {
        //dbcontext yerine IdentityDbContext'den miras alıp role, user ve key değerinin türünü belirtiyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-FUO4J03;database=CentalDb;integrated security=true;trustServerCertificate=true");
            //lAZY LOADİNG'İ KULLANMAK İÇİN
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<UserSocial> UserSocials { get; set; }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}
