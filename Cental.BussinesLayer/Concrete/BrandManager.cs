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
    public class BrandManager : IBrandService
    {
        private readonly IBranDal _branDal;

        public BrandManager(IBranDal branDal)
        {
            _branDal = branDal;
        }

        public void TCreate(Brand entity)
        {
            _branDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _branDal.Delete(id);
        }

        public List<Brand> TGetAll()
        {
           return _branDal.GetAll();
        }

        public Brand TGetById(int id)
        {
            return _branDal.GetById(id);
        }

        public void TUpdate(Brand entity)
        {
            _branDal.Update(entity);
        }
    }
}
