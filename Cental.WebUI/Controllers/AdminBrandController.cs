using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.BrandsDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminBrandController(IBrandService _brandService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var brands = _brandService.TGetAll();
            var values = _mapper.Map<List<ResultBrandDto>>(brands);
            return View(values);
        }

        public IActionResult DeleteBrands(int id)
        {
            _brandService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateBrands()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBrands(CreateBrandDto model)
        {
            //Validator kontrol 
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var brands = _mapper.Map<Brand>(model);
            _brandService.TCreate(brands);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateBrands(int id)
        {
            var brand = _brandService.TGetById(id);
            var values = _mapper.Map <Brand> (brand);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBrands(UpdateBrandDto model)
        {
            var brand = _brandService.TGetById(model.BrandId);
            var values = _mapper.Map<Brand>(brand);
            _brandService.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
