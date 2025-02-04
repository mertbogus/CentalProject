using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.Enums;
using Cental.EntityLayer.Entities;
using Cental.WebUI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCarController(ICarService _carService, IMapper _mapper, IBrandService _brandService) : Controller
    {
        private void GetValuesInDropDown()
        {
            ViewBag.gasTypes = GetEnumValues.GetEnums<GasTypes>();
            ViewBag.gearTypes = GetEnumValues.GetEnums<GearTypes>();
            ViewBag.transmissions = GetEnumValues.GetEnums<TransmissionsTypes>();
            ViewBag.Brands = (from x in _brandService.TGetAll()
                              select new SelectListItem
                              {
                                  Text = x.BrandName,
                                  Value = x.BrandId.ToString()
                              }).ToList();
        }
        public IActionResult Index()
        {
            var values = _carService.TGetAll();
            var cars = _mapper.Map<List<ResultCarDto>>(values);
            return View(cars);
        }

        public IActionResult CreateCar()
        {
            GetValuesInDropDown();
            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(CreateCarDto model)
        {
            GetValuesInDropDown();
            var newCar = _mapper.Map<Car>(model);
            _carService.TCreate(newCar);
            return RedirectToAction("Index");
        }
    }
}
