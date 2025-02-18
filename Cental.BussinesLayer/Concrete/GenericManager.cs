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
    public class GenericManager<T> : IGenericService<T> where T :BaseEntity
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void TCreate(T entity)
        {
            _genericDal.Create(entity);
            
        }

        public void TDelete(int id)
        {
            _genericDal.Delete(id);
        }

        public List<T> TGetAll()
        {
            return _genericDal.GetAll();
        }

        public T TGetById(int id)
        {
           return _genericDal.GetById(id);
        }

        public void TUpdate(T entity)
        {
            _genericDal.Update(entity);
            
        }
    }
}
