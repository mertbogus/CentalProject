using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Cars
{
    public class _UICarCategoriesComponent(ICarService _carService, IMapper _mapper) : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var values= _carService.GetCarCategories();
            return View(values);
        }
    }
}
