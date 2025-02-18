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
    public class ServicesManager : IServicesService
    {
        private readonly IServiceDal _serviceDal;

        public ServicesManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TCreate(Service entity)
        {
            _serviceDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _serviceDal.Delete(id);
        }

        public List<Service> TGetAll()
        {
            return _serviceDal.GetAll();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
