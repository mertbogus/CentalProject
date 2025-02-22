using Cental.DtoLayer.BookingDtos;
using Cental.DtoLayer.CarDtos;
using Cental.EntityLayer.Entities;

namespace Cental.WebUI.ViewModels
{
    public class CarBookingViewModel
    {
        // Cars bilgileri
      public List<ResultCarDto> Cars { get; set; }

        // Bookings bilgileri
        public List<ResultBookingDto> Bookings { get; set; }
    }
}
