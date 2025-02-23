using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ReviewDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Areas.Manager.Controllers
{
    [Authorize(Roles = "Manager"), Area("Manager")]
    public class ManagerReviewController(IReviewService _reviewService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var review = _reviewService.TGetAll();
            var reviewdtos=_mapper.Map<List<ResultReviewDto>>(review);
            return View(reviewdtos);
        }

        [HttpPost]

        public IActionResult ShowComments(int id)
        {
            var comments = _reviewService.TGetById(id);
            if (comments != null)
            {
                comments.ShowComments = true;
                _reviewService.TUpdate(comments); 
            }

            
            return RedirectToAction("Index");
        }


        [HttpPost]

        public IActionResult HiddenComments(int id)
        {
            var comments = _reviewService.TGetById(id);
            if (comments != null)
            {
                comments.ShowComments = true;
                _reviewService.TUpdate(comments);
            }


            return RedirectToAction("Index");
        }
    }
}
