using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminFeatureController(IFeatureService _featureService, IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var feature = _featureService.TGetAll();
            var featuresdto = _mapper.Map<List<ResultFeatureDto>>(feature);
            return View(featuresdto);
        }

        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
           return  RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var features = _mapper.Map<Feature>(model);
            _featureService.TCreate(features);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var feature = _featureService.TGetById(id);
            var featureDto = _mapper.Map<UpdateFeatureDto>(feature); // Feature -> UpdateFeatureDto'ya dönüştürme
            return View(featureDto);
        }

        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureDto model)
        {
            var feature=_featureService.TGetById(model.FeatureId);
            var features = _mapper.Map(model,feature);
            _featureService.TUpdate(features);
            return RedirectToAction("Index");
        }
    }
}
