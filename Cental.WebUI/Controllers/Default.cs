using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
