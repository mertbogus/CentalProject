using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.ViewComponents
{
    public class _ManagerLayoutHeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
