﻿using AgroFarmMongoDb.Services.Testimonial;
using Microsoft.AspNetCore.Mvc;

namespace AgroFarmMongoDb.ViewComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllTestimonial();
            return View(values);
        }
    }
}
