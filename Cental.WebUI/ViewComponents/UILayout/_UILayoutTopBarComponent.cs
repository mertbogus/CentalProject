using AutoMapper;
using Cental.BussinesLayer.Abstract;
using Cental.DtoLayer.ContactDtos;
using Cental.DtoLayer.SocialMediaDtos;
using Cental.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.UILayout
{
    public class _UILayoutTopBarComponent(IContactService _contactService, ISocialMediaService _socialMediaService, IMapper _mapper) : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            var contacts = _contactService.TGetAll();
            var contactsdto = _mapper.Map<List<ResultListUIContactDto>>(contacts);
            var social = _socialMediaService.TGetAll();
            var socialsdto = _mapper.Map<List<ResultUISocialMediaDto>>(social);
            var model = new ContactSocialMediaViewModel
            {
                Contacts = contactsdto,
                Socials = socialsdto,
            };
            return View(model);
        }
    }
}
