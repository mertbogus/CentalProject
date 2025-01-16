using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Abstract
{
    public interface IGenericDal<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);

        void Delete(int id);

        void Create(T entity);

        void Update(T entity);
    }
}
