using Microsoft.AspNetCore.Mvc;
using SenateCore.IServices;
using SenateCore.Services;

namespace QMS.Controllers
{
    public class BasicPayScaleController : Controller
    {
        private readonly IBasicPayScaleService _basicPayScaleService;
        public BasicPayScaleController(IBasicPayScaleService basicPayScaleService)
        {
            _basicPayScaleService = basicPayScaleService;
        }

        public async Task<IActionResult>  Index()
        {
            var apiData = await _basicPayScaleService.GetBasicPayScaleAsync();
            ViewData["ApiData"] = apiData;  // Passing data to the view
            return View();
        }
    }
}
