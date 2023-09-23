using AgroFarmMongoDb.Services.WhatWeDo;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultWhatWeDoComponentPartial : ViewComponent
    {
        private readonly IWhatWeDoService _whatWeDoService;

        public _DefaultWhatWeDoComponentPartial(IWhatWeDoService whatWeDoService)
        {
            _whatWeDoService = whatWeDoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _whatWeDoService.GetAllWhatWeDo();
            return View(values);
        }
    }
}
