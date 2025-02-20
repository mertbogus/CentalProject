using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.ViewComponents
{
    public class _ManagerLayaoutSideBarComponent(UserManager<AppUser> _userManager) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.NameSurname = string.Join(" ", user.FirstName, user.LastName);
            ViewBag.UserImage = user.ImageUrl;
            return View();
        }
    }
}
