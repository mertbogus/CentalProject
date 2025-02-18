using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.FactCounter
{
    public class _UIFactCounterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
