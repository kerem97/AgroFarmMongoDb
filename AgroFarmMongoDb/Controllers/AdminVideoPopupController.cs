using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.VideoPopup;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminVideoPopupController : Controller
    {
        private readonly IVideoPopupService _videoPopupService;

        public AdminVideoPopupController(IVideoPopupService videoPopupService)
        {
            _videoPopupService = videoPopupService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _videoPopupService.GetAllVideoPopup();
            return View(values);
        }
        [HttpGet]

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(VideoPopup videoPopup)
        {
            await _videoPopupService.CreateVideoPopup(videoPopup);
            return RedirectToAction("Index");
        }
    }
}
