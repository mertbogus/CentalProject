using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Cars
{
    public class _UICarCategoriesComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
