using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DtoLayer.UserSocialDtos;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class UserSocialManager(IUserSocialDal _userSocialDal,IMapper mapper) : IUserSocialService
    {

        public void TCreate(UserSocial entity)
        {
            _userSocialDal.Create(entity);
        }

        public void TDelete(int id)
        {
            _userSocialDal.Delete(id);
        }

        public List<UserSocial> TGetAll()
        {
            return _userSocialDal.GetAll();
        }

        public UserSocial TGetById(int id)
        {
            return _userSocialDal.GetById(id);
        }

        public List<ResultUserSocialDto> TGetSocialsByUserId(int userId)
        {
            var values = _userSocialDal.GetSocialsByUserId(userId);

            return mapper.Map<List<ResultUserSocialDto>>(values);
        }

        public void TUpdate(UserSocial entity)
        {
            _userSocialDal.Update(entity);  
        }
    }
}
