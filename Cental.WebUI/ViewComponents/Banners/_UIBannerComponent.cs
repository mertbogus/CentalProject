using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Banners
{
    public class _UIBannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
