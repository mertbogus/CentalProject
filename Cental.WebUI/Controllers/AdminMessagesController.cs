using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.MessageDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminMessagesController(IMapper _mapper, IMessagesService _messageService) : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var message = _messageService.TGetAll().Where(x=>x.MessageStatus==false);
            var messages=_mapper.Map<List<ResultMessageDto>>(message);
            return View(messages);
        }

        [HttpPost]

        public IActionResult ReadMessage(int id)
        {
            var message = _messageService.TGetById(id);

            if (message != null)
            {
                message.MessageStatus = true;
                _messageService.TUpdate(message); // 
            }

            // Booking güncellendikten sonra aynı sayfaya yönlendirme yapabiliriz
            return RedirectToAction("Index");
        }
    }
}
