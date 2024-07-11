using DateTime.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateTime.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentTime = System.DateTime.Now;
            return View();
        }
    }
}
