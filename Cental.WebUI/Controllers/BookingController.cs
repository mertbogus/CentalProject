using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController(IBookingService _bookingService, IMapper _mapper, UserManager<AppUser> _userManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookingHireAsync(CreateBookingDto createBookingDto)
        {
            var bookings=_mapper.Map<Booking>(createBookingDto);
            bookings.BookingStatus = "Onay Bekliyor";
            var users= await _userManager.FindByNameAsync(User.Identity.Name);
            if (users.Id!=0)
            {
                bookings.UserId = users.Id;
                _bookingService.TCreate(bookings);
                return NoContent();
            }
            return NoContent();
        }
    }
}
