﻿using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using Cental.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Concrete
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        public EfCarDal(CentalContext context) : base(context)
        {
        }

        public List<Car> GetCarCategories()
        {
            return _context.Cars.OrderByDescending(x => x.CarId).Take(6).ToList();
        }

        public List<Car> GetCarsWithBrands()
        {
            return _context.Cars.Include(x => x.Brand).ToList();
        }
    }
}
