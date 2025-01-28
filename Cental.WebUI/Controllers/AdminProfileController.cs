using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminProfileController(UserManager<AppUser> _userManager, IImageService _imageService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var dto=user.Adapt<ProfileEditDto>();
            return View(dto);
        }

        [HttpPost]

        public async Task<IActionResult> Index(ProfileEditDto model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var succed = await _userManager.CheckPasswordAsync(user,model.CurrentPassword);

            if (succed)
            {
                if (model.ImageFile!=null)
                {
                    model.ImageUrl=await _imageService.SaveImage(model.ImageFile);
                }
                var  updateUser=model.Adapt<AppUser>();

                var result = await _userManager.UpdateAsync(updateUser);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminAbout");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                return View(model);
            }
            ModelState.AddModelError(string.Empty, "Girdiğiniz Şifre Hatalı. Güncelleme Yapılamadı.");
            return View(model);
        }
    }
}
