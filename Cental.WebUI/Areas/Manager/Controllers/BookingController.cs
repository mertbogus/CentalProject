using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Authorize(Roles = "Manager"),Area("Manager")]
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
