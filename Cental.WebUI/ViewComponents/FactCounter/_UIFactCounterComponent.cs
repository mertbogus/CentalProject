using Cental.BussinesLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.FactCounter
{
    public class _UIFactCounterComponent(UserManager<AppUser> _userManager, ICarService _carService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.TotalCars = _carService.TGetAll().Count();
            ViewBag.TotalCustomer = _userManager.Users.Count();
            ViewBag.TotalKilometers = _carService.TGetAll().Select(x => x.Kilometer).Sum();
            ViewBag.TotalCarBrands=_carService.TGetAll().Select(x=>x.Brand).Distinct().Count();
            return View();
        }
    }
}
