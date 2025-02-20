using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Booking
{
    public class _UIBookingComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
        
    }
}
