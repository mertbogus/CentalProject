﻿using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.BookingDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Authorize(Roles = "Manager"), Area("Manager")]
    public class ManagerBookingController(IBookingService _bookingService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {

            var bookings = _bookingService.TGetAll();
            var bookingsdto = _mapper.Map<List<ResultBookingDto>>(bookings);
            return View(bookingsdto);
        }

        [HttpPost]
        public IActionResult CancelBooking(int id)
        {
            var booking = _bookingService.TGetById(id);

            if (booking != null)
            {
                booking.BookingStatus = "İptal Edildi";
                _bookingService.TUpdate(booking); // Booking güncelleniyor
            }

            // Booking güncellendikten sonra aynı sayfaya yönlendirme yapabiliriz
            return RedirectToAction("Index");
        }

        public IActionResult SuccesBooking(int id)
        {
            var booking = _bookingService.TGetById(id);

            if (booking != null)
            {
                booking.BookingStatus = "Onaylandı";
                _bookingService.TUpdate(booking); // Booking güncelleniyor
            }

            // Booking güncellendikten sonra aynı sayfaya yönlendirme yapabiliriz
            return RedirectToAction("Index");
        }
    }
}
