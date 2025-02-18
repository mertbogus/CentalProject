using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Services
{
    public class _UIServicesComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
