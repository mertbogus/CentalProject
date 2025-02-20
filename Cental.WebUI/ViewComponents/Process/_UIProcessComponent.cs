using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.DtoLayer.FeatureDtos;
using Cental.DtoLayer.ProcessDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Process
{
    public class _UIProcessComponent : ViewComponent
    {
        private readonly IProcessService _processService;
        private readonly IMapper _mapper;

        public _UIProcessComponent(IProcessService processService, IMapper mapper)
        {
            _processService = processService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var process = _processService.TGetAll();
            var processdto = _mapper.Map<List<ResultUIProcessDto>>(process);
            return View(processdto);
        }
    }
}
