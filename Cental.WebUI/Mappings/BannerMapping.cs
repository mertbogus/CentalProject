using AutoMapper;
using Cental.DtoLayer.BannerDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class BannerMapping: Profile
    {
        public BannerMapping()
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();   
            CreateMap<Banner, CreateBannerDto>().ReverseMap();   
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();   
        }
    }
}
