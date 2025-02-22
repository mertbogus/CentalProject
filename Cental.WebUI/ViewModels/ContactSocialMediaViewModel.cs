using Cental.DtoLayer.BookingDtos;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.ContactDtos;
using Cental.DtoLayer.SocialMediaDtos;

namespace Cental.WebUI.ViewModels
{
    public class ContactSocialMediaViewModel
    {
        public List<ResultListUIContactDto> Contacts { get; set; }

        // Bookings bilgileri
        public List<ResultUISocialMediaDto> Socials { get; set; }
    }
}
