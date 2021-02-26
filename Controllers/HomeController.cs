//using DateTimeIssueDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeIssueDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        public IActionResult CheckDate(DateTime date1, DateTime date2)
        {
            var date1TimeKind = date1.Date.Kind.ToString();
            var date2TimeKind = date2.Date.Kind.ToString();
            TempData["date1TimeKind"] = date1TimeKind;
            TempData["date2TimeKind"] = date2TimeKind;
            return View("CheckDate");
        }
    }
}
