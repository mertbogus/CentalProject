using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DtoLayer.ContactDtos;
using Cental.DtoLayer.MessageDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class MessagesController(IMessagesService _messagesService, IMapper _mapper, IContactService _contactService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SendMessage(CreateMessageDto model)
        {
            if (ModelState.IsValid)
            {
                var message = _mapper.Map<Message>(model);
                _messagesService.TCreate(message);
                return RedirectToAction("Index", "Messages"); // Yönlendirmeyi buraya ekledik
            }

            // Eğer model geçerli değilse, aynı sayfaya geri dönüyoruz
            return View(model);
        }

        

    }
}
