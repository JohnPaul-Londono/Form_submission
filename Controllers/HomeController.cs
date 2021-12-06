using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Form_submission.Models;

namespace Form_submission.Controllers
{
    public class HomeController : Controller
    {
        static Form oneForm;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("process")]
        public IActionResult Process(Form newForm)
        {
            if(ModelState.IsValid)
            {
                oneForm = newForm;
                return RedirectToAction("Result");
            } else{
                return View ("Index");
            }
        }

        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View(oneForm);
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
