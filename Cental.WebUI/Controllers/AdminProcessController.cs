using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Cental.DtoLayer.ProcessDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminProcessController(IProcessService _processService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var value = _processService.TGetAll();
            var processdto=_mapper.Map<List<ResultProcessDto>>(value);
            return View(processdto);
        }

        public IActionResult DeleteProcess(int id)
        {
            _processService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateProcess()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProcess(CreateProcessDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var process=_mapper.Map<Process>(model);
            _processService.TCreate(process);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProcess(int id)
        {
            var process = _processService.TGetById(id);
            var processDto = _mapper.Map<UpdateProcessDto>(process); // Feature -> UpdateFeatureDto'ya dönüştürme
            return View(processDto);
        }

        [HttpPost]
        public IActionResult UpdateProcess(UpdateProcessDto model)
        {
            var process = _mapper.Map<Process>(model);
            _processService.TUpdate(process);
            return RedirectToAction("Index");
        }
    }
}
