using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ServiceDto;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Services
{
    public class _UIServicesComponent : ViewComponent
    {
        private readonly IServicesService _servicesService;
        private readonly IMapper _mapper;

        public _UIServicesComponent(IServicesService servicesService, IMapper mapper)
        {
            _servicesService = servicesService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _servicesService.TGetAll();
            var services = _mapper.Map<List<ResultServiceUIList>>(values);
            return View(services);
        }
    }
}
