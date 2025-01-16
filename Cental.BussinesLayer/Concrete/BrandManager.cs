using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class BrandManager : GenericManager<Brand>, IBranService
    {
        public BrandManager(IGenericDal<Brand> genericDal) : base(genericDal)
        {
        }
    }
}
