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
    public class EfuserSocialDal : GenericRepository<UserSocial>, IUserSocialDal
    {
        public EfuserSocialDal(CentalContext context) : base(context)
        {
        }

        public List<UserSocial> GetSocialsByUserId(int userId)
        {
            return _context.UserSocials.Where(x => x.UserId == userId).ToList();
        }
    }
}
