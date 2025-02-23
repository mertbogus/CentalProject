using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ReviewDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Testimonial
{
    public class _UITestimonialComponent(IReviewService _reviewService, IMapper _mapper) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = _reviewService.TGetAll().Where(x => x.ShowComments == true).Distinct().OrderBy(x => Guid.NewGuid()).Take(6).ToList();
            var comments=_mapper.Map<List<ResultReviewUIDto>>(values);
            return View(comments);
        }
    }
}
