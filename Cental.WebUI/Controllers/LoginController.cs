using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    //Primary Concstudoctur
    public class LoginController(SignInManager<AppUser> _signInManager) : Controller
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

            return RedirectToAction("Index","AdminAbout");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Default");
        }
    }
}
