using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Cental.DtoLayer.UserSocialDtos;
using Cental.BussinesLayer.Abstract;
using AutoMapper;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    
    public class MySocialController(IUserSocialService _userSocialService, IMapper _mapper, UserManager<AppUser> _usermanager) : Controller
    {
        [Authorize(Roles ="Manager"), Area("Manager")]
        public async Task<IActionResult> IndexAsync()
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var values = _userSocialService.TGetSocialsByUserId(user.Id);
            return View(values);
        }

        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateUserSocialDto model)
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var newSocial=_mapper.Map<UserSocial>(model);
            newSocial.UserId = user.Id;
            _userSocialService.TCreate(newSocial);

            return RedirectToAction("Index");
        }
    }
}

