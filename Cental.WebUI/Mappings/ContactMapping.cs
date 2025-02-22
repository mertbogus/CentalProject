using AutoMapper;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.ContactDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.Mappings
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultListUIContactDto>().ReverseMap();
            CreateMap<Contact, ResultListContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();

        }
    }
}
