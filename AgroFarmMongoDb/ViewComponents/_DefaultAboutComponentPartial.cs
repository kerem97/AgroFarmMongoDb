using AgroFarmMongoDb.Services.About;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAbout();
            return View(values);
        }
    }
}
