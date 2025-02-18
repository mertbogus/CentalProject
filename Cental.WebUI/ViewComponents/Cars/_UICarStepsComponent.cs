using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Cars
{
    public class _UICarStepsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
