using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using Cental.DtoLayer.BookingDtos;
using Cental.DtoLayer.CarDtos;
using Cental.EntityLayer.Entities;
using Cental.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Cental.WebUI.Controllers
{
    public class AdminDashboardController(ICarService _carService, IBookingService _bookingService, IMapper _mapper ) : Controller
    {
        public void AdminStatistics()
        {
            ViewBag.Totalcars = _carService.TGetAll().Count();
            ViewBag.Totaldieselcount = _carService.TGetAll().Where(x => x.GasType == "Dizel").Count();
            ViewBag.TotalPetrolcount = _carService.TGetAll().Where(x => x.GasType == "Benzin").Count();
            ViewBag.TotalBrands = _carService.TGetAll().Select(x => x.Brand).Count(); ;
            ViewBag.TotalGearOtomaticcount = _carService.TGetAll().Where(x => x.GearType == "Otomatik").Count();
            ViewBag.TotalBooking = _bookingService.TGetAll().Count();
            ViewBag.TotalSuccesBooking = _bookingService.TGetAll().Where(x => x.BookingStatus == "Onaylandı").Count();
            ViewBag.TotalCancelBooking = _bookingService.TGetAll().Where(x => x.BookingStatus == "İptal Edildi").Count();
            ViewBag.TotalPendingApprovalBooking = _bookingService.TGetAll().Where(x => x.BookingStatus == "Onay Bekliyor").Count();
        }
        public IActionResult Index()
        {

            AdminStatistics();

            var cars = _carService.TGetAll().TakeLast(6);
            var carsdto = _mapper.Map<List<ResultCarDto>>(cars);
            var booking = _bookingService.TGetAll().TakeLast(5);
            var bookingsdto = _mapper.Map<List<ResultBookingDto>>(booking);
            var model = new CarBookingViewModel
            {
                Cars = carsdto,
                Bookings = bookingsdto,
            };
            return View(model);
        }
    }
}
