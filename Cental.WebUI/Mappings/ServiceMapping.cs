using AutoMapper;
using Cental.DtoLayer.ServiceDto;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping() 
        { 
           CreateMap<Service,ResultServiceDto>().ReverseMap();
           CreateMap<Service,ResultServiceUIList>().ReverseMap();
           CreateMap<Service,CreateServiceDto>().ReverseMap();
           CreateMap<Service,UpdateServiceDto>().ReverseMap();
        }
    }
}
