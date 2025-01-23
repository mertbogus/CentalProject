using Cental.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Abstract
{
    public  interface ICarService : IGenericService<Car>
    {
        public List<Car> GetCarsWithBrands();
    }
}
