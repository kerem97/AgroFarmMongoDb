using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.WhatWeDo;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminWhatWeDoController : Controller
    {
        private readonly IWhatWeDoService _whatWeDoService;

        public AdminWhatWeDoController(IWhatWeDoService whatWeDoService)
        {
            _whatWeDoService = whatWeDoService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _whatWeDoService.GetAllWhatWeDo();
            return View(values);
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(WhatWeDo whatWeDo)
        {
            _whatWeDoService.CreateWhatWeDo(whatWeDo);
            return RedirectToAction("Index");
        }
    }
}
