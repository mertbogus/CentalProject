using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
