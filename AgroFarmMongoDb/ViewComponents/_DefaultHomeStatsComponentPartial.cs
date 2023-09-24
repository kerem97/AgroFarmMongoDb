using AgroFarmMongoDb.Services.Statistic;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultHomeStatsComponentPartial : ViewComponent
    {
        private readonly IStatisticService _statisticService;

        public _DefaultHomeStatsComponentPartial(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _statisticService.GetAllStatistic();
            return View(values);
        }
    }
}
