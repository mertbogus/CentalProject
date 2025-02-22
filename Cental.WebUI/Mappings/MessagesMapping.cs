using AutoMapper;
using Cental.DtoLayer.BrandsDtos;
using Cental.DtoLayer.MessageDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class MessagesMapping : Profile
    {
        public MessagesMapping()
        {
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, ResultMessageDto>().ReverseMap();
        }
    }
}
