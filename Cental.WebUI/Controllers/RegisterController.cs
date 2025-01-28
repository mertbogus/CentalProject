using AutoMapper;
using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController(UserManager<AppUser> _userManager, IMapper _mapper) : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(UserRegisterDto model)
        {
            var user = _mapper.Map<AppUser>(model);

            if (!ModelState.IsValid)
            {
                return View(model);
            }


            //bir küçük harf büyük harf rakam özel karakter en az 6 
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(model);
            }

            return RedirectToAction("Index", "Login");



        }

    }
}