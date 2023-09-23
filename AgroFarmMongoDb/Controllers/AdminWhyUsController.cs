using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.WhyUs;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminWhyUsController : Controller
    {
        private readonly IWhyUsService _whyUsService;

        public AdminWhyUsController(IWhyUsService whyUsService)
        {
            _whyUsService = whyUsService;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(WhyUs whyUs)
        {
            await _whyUsService.CreateWhyUs(whyUs);
            return RedirectToAction("Index");
        }
    }
}
