using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace Cental.WebUI.ViewComponents.Default
{
    public class _DefaultManagerComponent(UserManager<AppUser> _userManager):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var managers = await _userManager.GetUsersInRoleAsync("Manager");
            var dtomanager= managers.Adapt<IList<ResultUserDto>>();
            return View(dtomanager.TakeLast(4).ToList());
        }
    }
}
