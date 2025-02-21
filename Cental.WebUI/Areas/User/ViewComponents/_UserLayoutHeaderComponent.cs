using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.User.ViewComponents
{
    public class _UserLayoutHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
