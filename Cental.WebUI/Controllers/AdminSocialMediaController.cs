using AutoMapper;
using AutoMapper.Features;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Cental.DtoLayer.SocialMediaDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminSocialMediaController(ISocialMediaService _socialMediaService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var social = _socialMediaService.TGetAll();
            var socialsdto = _mapper.Map<List<ResultSocialMediaDto>>(social);
            return View(socialsdto);
        }

        public IActionResult DeleteSocialMedia(int id)
        {

            _socialMediaService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult CreateSocialMedia(int id)
        {
            return View();
        }


        [HttpPost]

        public IActionResult CreateSocialMedia(CreateSocialMediaDto model)
        {
            var social=_mapper.Map<SocialMedia>(model);
            _socialMediaService.TCreate(social);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateSocialMedia(int id)
        {
            var social=_socialMediaService.TGetById(id);
            var socialDto = _mapper.Map<UpdateSocialMediaDto>(social); // Feature -> UpdateFeatureDto'ya dönüştürme
            return View(socialDto);
        }

        [HttpPost]
        public IActionResult UpdatesSocialMedia(UpdateSocialMediaDto model)
        {
            var social = _socialMediaService.TGetById(model.SocialMediaId);
            var socials = _mapper.Map(model, social);
            _socialMediaService.TUpdate(social);
            return RedirectToAction("Index");
        }
    }
}
