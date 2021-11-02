using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AllinDigitalTools.Models;

namespace AllinDigitalTools.Controllers
{
    public class InstaController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(PersonModel person)
        {
            string name = person.Name;
            ViewBag.outname = name;
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
