using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Layout()
        {
            return View();
        }

    }
}
