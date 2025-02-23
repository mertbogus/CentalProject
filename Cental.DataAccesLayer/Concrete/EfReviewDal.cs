using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repositories;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Concrete
{
    public class EfReviewDal : GenericRepository<Review>, IReviewDal
    {
        public EfReviewDal(CentalContext context) : base(context)
        {
        }

        public List<Review> TGetReviewsUserById(int userId)
        {
            return _context.Reviews.Where(x=> x.UserId == userId).ToList();
        }
    }
}
