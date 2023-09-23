using AgroFarmMongoDb.Services.VideoPopup;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultVideoPopupComponentPartial : ViewComponent
    {
        private readonly IVideoPopupService _videoPopup;

        public _DefaultVideoPopupComponentPartial(IVideoPopupService videoPopup)
        {
            _videoPopup = videoPopup;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _videoPopup.GetAllVideoPopup();
            return View(values);
        }
    }
}
