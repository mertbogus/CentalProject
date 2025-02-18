using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Testimonial
{
    public class _UITestimonialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
