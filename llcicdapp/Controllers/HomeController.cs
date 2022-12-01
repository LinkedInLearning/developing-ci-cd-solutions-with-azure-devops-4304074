using llcicdapp.Models;
using llcicdapp.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace llcicdapp.Controllers
{
    public class HomeController : Controller
    {
       
        readonly IAssessmentRepo assessmentRepo;
        public HomeController(IAssessmentRepo _assessmentRepo)
        {
            assessmentRepo = _assessmentRepo;
        }

        public IActionResult Index()
        {
            var model = assessmentRepo.GetAssessments();
            return View(model);
        }





        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
