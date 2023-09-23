using AgroFarmMongoDb.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultWhyUsComponentPartial : ViewComponent
    {
        private readonly IWhyUsService _whyUsService;

        public _DefaultWhyUsComponentPartial(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _whyUsService.GetAllWhyUs();
            return View(values);
        }
    }
}
