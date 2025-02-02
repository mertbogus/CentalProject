using Cental.DtoLayer.RoleDtos;
using Cental.EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class RoleController(RoleManager<AppRole> _roleManager) : Controller
    {
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            var dto=roles.Adapt<List<ResultRoleDto>>();
            return View(dto);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDto model)
        {
            var role = model.Adapt<AppRole>();
           var result= await _roleManager.CreateAsync(role);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    return View(error);
                }
            }
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            var dtorole=_roleManager.Adapt<UpdateRoleDto>();
            return View(dtorole);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateRoleDto model)
        {
            var role=model.Adapt<AppRole>();
            var result = await _roleManager.UpdateAsync(role);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    return View(error);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
