using AutoMapper;
using Cental.DtoLayer.AboutDtos;
using Cental.DtoLayer.BannerDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            var thisYear = DateTime.Now.Year;
            CreateMap<About, ResultListAboutDto>().ForMember(dst => dst.ExperienceYear,o=>o.MapFrom(src=>thisYear-src.StartYear));
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
        }

    }
}
