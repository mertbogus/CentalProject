using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    //Primary Concstudoctur
    public class LoginController(SignInManager<AppUser> _signInManager, UserManager<AppUser> _userManager) : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            await _signInManager.SignOutAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginDto model, string? returnUrl)
        {

            var result = await _signInManager.PasswordSignInAsync(model.UserName,model.Password,false,true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Girmiş olduğunuz kullanıcı adı veya şifre hatalı!");
                return View(model);
            }

            if (returnUrl!=null)
            {
                return Redirect(returnUrl);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            var userroles = await _userManager.GetRolesAsync(user);
            foreach (var role in userroles)
            {
                if (role=="Admin")
                {
                    return RedirectToAction("Index", "AdminAbout");
                }
                if (role=="Manager")
                {
                    return RedirectToAction("Index", "MySocial",new {area="Manager"});
                }
                if (role == "User")
                {
                    return RedirectToAction("Index", "UserProfile", new { area = "User" });
                }
            }

            return RedirectToAction("Index");
          
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Default");
        }
    }
}
