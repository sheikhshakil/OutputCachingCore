using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OutputCachingCore.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace OutputCachingCore.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 20, VaryByParam = "user")]
        public IActionResult Index(string user = "")
        {

            DateTime date = DateTime.Now;

            return View(date);
        }
    }
}
