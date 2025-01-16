using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultAboutComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public _DefaultAboutComponent(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetAll();
            var abouts=_mapper.Map<List<ResultListAboutDto>>(values);
            return View(abouts);
        }
    }
}
