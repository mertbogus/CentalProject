using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.CarDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminCarController(ICarService _carService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values = _carService.GetCarsWithBrands();
            var cars = _mapper.Map<List<ResultCarDto>>(values);
            return View(cars);
        }
    }
}
