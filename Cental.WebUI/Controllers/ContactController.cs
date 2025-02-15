using Cental.DtoLayer.MessageDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SendMessage(CreateMessageDto model)
        {
            //_messageService.Create(model);
            return NoContent();
        }

    }
}
