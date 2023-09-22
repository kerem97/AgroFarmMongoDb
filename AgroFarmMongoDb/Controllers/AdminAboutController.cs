using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.About;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAbout();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(About about)
        {
            await _aboutService.CreateAbout(about);
            return RedirectToAction("Index");
        }
    }
}
