using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApiAspNetCore.Controllers.v3
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
            // Sunil - 8/18/22
        }
    }
}
