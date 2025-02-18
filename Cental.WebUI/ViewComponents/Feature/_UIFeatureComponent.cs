using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.DtoLayer.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.Feature
{
    public class _UIFeatureComponent : ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public _UIFeatureComponent(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var feature = _featureService.TGetAll();
            var featuresdto= _mapper.Map<List<ResultIUlListFeature>>(feature);
            return View(featuresdto);
        }
    }
}
