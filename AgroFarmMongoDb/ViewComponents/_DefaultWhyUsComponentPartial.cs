using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultWhyUsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
