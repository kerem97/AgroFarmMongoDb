using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
