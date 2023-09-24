using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.Statistic;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminStatisticController : Controller
    {
        private readonly IStatisticService _statisticService;

        public AdminStatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
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

        public async Task<IActionResult> Create(Statistic statistic)
        {
            await _statisticService.CreateStatistic(statistic);
            return View();
        }
    }
}
