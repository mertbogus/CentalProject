using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class RoleAssignController(UserManager<AppUser> _usermanager) : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
