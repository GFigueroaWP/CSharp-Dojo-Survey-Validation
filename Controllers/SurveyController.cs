using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class SurveyController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("survey")]
    public IActionResult Survey(Survey survey)
    {
        if (ModelState.IsValid)
        {
            return View("survey", survey);
        }
        else
        {
            return View("Index");
        }
    }

}