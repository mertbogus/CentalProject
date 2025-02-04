using Cental.DtoLayer.UserDtos;
using Cental.EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleAssignController(UserManager<AppUser> _usermanager, RoleManager<AppRole> _roleManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var users = await _usermanager.Users.ToListAsync();
            var userdto=new List<ResultUserDto>();
            foreach (var user in users)
            {
                var dto = new ResultUserDto();
                dto.Roles = await _usermanager.GetRolesAsync(user);
                dto.Id = user.Id;
                dto.FirstName = user.FirstName;
                dto.UserName = user.UserName;
                dto.Email = user.Email;
                dto.LastName = user.LastName;

                userdto.Add(dto);
            }
            return View(userdto);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = await _usermanager.FindByIdAsync(id.ToString());
            //kullanıcının rollerini liste formatında alıyoruz.

            var roles = await _roleManager.Roles.ToListAsync();
            var userroles = await _usermanager.GetRolesAsync(user);
            ViewBag.FullName=string.Join(" ",user.FirstName,user.LastName);
            var assignRoledtoList = new List<AssignRoleDto>();

            //list formasında olan rolleri dönüyoruz
            foreach (var item in roles)
            {
                var model = new AssignRoleDto();
                model.UserId= user.Id;
                model.RoleName = item.Name;
                model.RoleId = item.Id;
                model.RoleExist = userroles.Contains(item.Name);
                assignRoledtoList.Add(model);
            }
            return View(assignRoledtoList);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleDto> model)
        {
            var UserId = model.Select(x => x.UserId).FirstOrDefault();
            var user = await _usermanager.FindByIdAsync(UserId.ToString());
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _usermanager.AddToRoleAsync(user,item.RoleName);
                }
                else
                {
                    await _usermanager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }
            return RedirectToAction("Index");
        }
    }

}
