using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ServiceDto;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminServicesController(IServicesService _servicesService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var service = _servicesService.TGetAll();
            var servicesdto=_mapper.Map<List<ResultServiceDto>>(service);
            return View(servicesdto);
        }

        public IActionResult DeleteService(int id)
        {
            _servicesService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(CreateServiceDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var services=_mapper.Map<Service>(model);
            _servicesService.TCreate(services);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = _servicesService.TGetById(id);
            var services=_mapper.Map<UpdateServiceDto>(values);
            return View(services);
        }

        [HttpPost]
        public IActionResult UpdateService(UpdateServiceDto model)
        {
            var values = _servicesService.TGetById(model.ServiceId);
            var services = _mapper.Map(model,values);
            _servicesService.TUpdate(services);
            return RedirectToAction("Index");
        }
    }
}
