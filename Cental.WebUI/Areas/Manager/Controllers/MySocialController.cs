using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Cental.DtoLayer.UserSocialDtos;
using Cental.BussinesLayer.Abstract;
using AutoMapper;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Authorize(Roles = "Manager"), Area("Manager")]
    public class MySocialController(IUserSocialService _userSocialService, IMapper _mapper, UserManager<AppUser> _usermanager) : Controller
    {

        public async Task<IActionResult> IndexAsync()
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var values = _userSocialService.TGetSocialsByUserId(user.Id);
            return View(values);
        }

        public IActionResult CreateSocials()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocials(CreateUserSocialDto model)
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var newSocial = _mapper.Map<UserSocial>(model);
            newSocial.UserId = user.Id;
            _userSocialService.TCreate(newSocial);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocial(int id)
        {
            _userSocialService.TDelete(id);

            return RedirectToAction("Index");
        }
    }
}