using Cental.DtoLayer.UserSocialDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Abstract
{
    public interface IUserSocialService : IGenericService<UserSocial>
    {
        List<ResultUserSocialDto> TGetSocialsByUserId(int userId);
    }
}
