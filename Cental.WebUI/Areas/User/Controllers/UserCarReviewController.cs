using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cental.WebUI.Areas.User.Controllers
{
    [Authorize(Roles = "User"), Area("User")]
    public class UserCarReviewController(IReviewService _reviewService, IMapper _mapper, UserManager<AppUser> _userManager, IBookingService _bookingService) : Controller
    {
        
        public async Task<ActionResult> IndexAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var reviews = _reviewService.TGetReviewsUserById(user.Id);
            return View(reviews);
        }


        public ActionResult DeleteReview(int id)
        {
            _reviewService.TDelete(id);
            return View();
        }

       
        public async Task<ActionResult> CreateReviewAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userCars = _bookingService.TGetAll()
                               .Where(r => r.UserId==user.Id && r.BookingStatus=="Onaylandı") // UserId'yi kullanarak filtrele
                               .Select(r => r.Cars)
  
                               .ToList();

            // ViewBag veya ViewData ile arabaları gönder
            ViewBag.UserCars = new SelectList(userCars, "CarId", "ModelName"); // Model, araba modelini temsil ediyor
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateReviewAsync(CreateReviewDto model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var review = _mapper.Map<Review>(model);
            review.UserId = user.Id;
            _reviewService.TCreate(review);
            return RedirectToAction("Index");
        }


    }
}
