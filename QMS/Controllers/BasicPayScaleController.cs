using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SenateCore.Contracts.Common;

using SenateCore.Models.CommonModels.BasicPayScaleModel;
using SenateCore.Repository.Common;
using SenateData.DataModels.Common;
using System.Reflection;

namespace QMS.Controllers
{
    public class BasicPayScaleController : Controller
    {
        private readonly IBasicPayScaleRepo _basicPayScaleRepo;
        public BasicPayScaleController(IBasicPayScaleRepo basicPayScaleRepo)
        {
            _basicPayScaleRepo = basicPayScaleRepo;
        }

        public async Task<IActionResult>  Index()
        {
            List<GetBasicPayScaleDto> basicPayScaleDtos = await _basicPayScaleRepo.GetAllAsync<GetBasicPayScaleDto>();
            ViewData["basicPayScaleDtos"] = basicPayScaleDtos;
            return View(basicPayScaleDtos);
        }
    }
}
