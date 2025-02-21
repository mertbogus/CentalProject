using Cental.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.ViewComponents.Booking
{
    public class _UIBookingComponent(ICarService _carService) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cars = _carService.TGetAll();

            ViewBag.cars = (from x in cars
                              select new SelectListItem
                              {
                                  Text = x.Brand.BrandName+ " " +x.ModelName,
                                  Value = x.CarId.ToString()
                              }).ToList();
            return View(cars);
        }
        
        
    }
}
