using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class ManagerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
