using AgroFarmMongoDb.Services.Banner;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultBannerComponentPartial : ViewComponent
    {
        private readonly IBannerService _bannerService;

        public _DefaultBannerComponentPartial(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetAllBanner();
            return View(values);
        }
    }
}
