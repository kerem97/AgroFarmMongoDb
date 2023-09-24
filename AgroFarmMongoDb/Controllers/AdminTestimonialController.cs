using AgroFarmMongoDb.Models;
using AgroFarmMongoDb.Services.Testimonial;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public AdminTestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(Testimonial testimonial)
        {
            await _testimonialService.CreateTestimonial(testimonial);
            return View();
        }
    }
}
