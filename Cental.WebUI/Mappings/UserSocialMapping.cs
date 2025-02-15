using AutoMapper;
using Cental.DtoLayer.UserDtos;
using Cental.DtoLayer.UserSocialDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class UserSocialMapping : Profile
    {
        public UserSocialMapping()
        {
            //source ==> destinasyon
            CreateMap<UserSocial, ResultUserSocialDto>().ForMember(dest => dest.SocialMediaUrl, o => o.MapFrom(src => src.Url));
            CreateMap<UserSocial, CreateUserSocialDto>().ReverseMap();
            CreateMap<UserSocial, UpdateUserSocialDto>().ReverseMap();
        }
    }
}
