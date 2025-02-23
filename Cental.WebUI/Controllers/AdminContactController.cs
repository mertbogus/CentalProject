using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ContactDtos;
using Cental.DtoLayer.ProcessDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminContactController(IContactService _contactService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _contactService.TGetAll();
            var contacts=_mapper.Map<List<ResultListContactDto>>(values);
            return View(contacts);
        }


        public IActionResult DeleteContact(int id)
        {
            _contactService.TDelete(id);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto model)
        {
            var contacts = _mapper.Map<Contact>(model);
            _contactService.TCreate(contacts);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var contact = _contactService.TGetById(id);
            var contactsDto = _mapper.Map<UpdateContactDto>(contact); // Feature -> UpdateFeatureDto'ya dönüştürme
            return View(contactsDto);
        }

        [HttpPost]
        public IActionResult UpdateContact(UpdateContactDto model)
        {
            var contact = _mapper.Map<Contact>(model);
            _contactService.TUpdate(contact);
            return RedirectToAction("Index");
        }
    }
}
