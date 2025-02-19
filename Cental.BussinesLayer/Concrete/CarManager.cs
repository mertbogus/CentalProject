using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concrete;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _Cardal;

        public CarManager(ICarDal cardal)
        {
            _Cardal = cardal;
        }

        public List<Car> GetCarCategories()
        {
            return _Cardal.GetCarCategories();
        }

        public List<Car> GetCarsWithBrands()
        {
            return _Cardal.GetCarsWithBrands();
        }

        public void TCreate(Car entity)
        {
            _Cardal.Create(entity);
        }

        public void TDelete(int id)
        {
            _Cardal.Delete(id);
        }

        public List<Car> TGetAll()
        {
            return _Cardal.GetAll();
        }

        public Car TGetById(int id)
        {
            return _Cardal.GetById(id);
        }

        public void TUpdate(Car entity)
        {
            _Cardal.Update(entity);
        }
    }
}
