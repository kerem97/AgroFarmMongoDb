using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.Banner;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminBannerController : Controller
    {
        private readonly IBannerService _bannerService;

        public AdminBannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.GetAllBanner();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Banner banner)
        {
            await _bannerService.CreateBanner(banner);
            return RedirectToAction("Index");
        }
    }
}
