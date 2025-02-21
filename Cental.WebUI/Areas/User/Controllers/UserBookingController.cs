using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.User.Controllers
{

    [Authorize(Roles = "User"), Area("User")]
    public class UserBookingController(IBookingService _bookingService, IMapper _mapper, UserManager<AppUser> _usermanager) : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var bookings = _bookingService.TGetBookingUserById(user.Id);
            return View(bookings);
        }
    }
}
