using AutoMapper;
using Cental.DtoLayer.BannerDtos;
using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<AppUser, UserRegisterDto>().ReverseMap();
        }
    }
}
