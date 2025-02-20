using AutoMapper;
using Cental.DtoLayer.ProcessDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class ProcessMaping : Profile
    {
        public ProcessMaping() {

            CreateMap<Process, ResultProcessDto>().ReverseMap();
            CreateMap<Process, CreateProcessDto>().ReverseMap();
            CreateMap<Process, UpdateProcessDto>().ReverseMap();
            CreateMap<Process, ResultUIProcessDto>().ReverseMap();
        
        }
    }
}
