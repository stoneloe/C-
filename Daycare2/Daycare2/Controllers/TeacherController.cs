﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Daycare2.Controllers
{
    public class TeacherController : Controller
    {
        //URL: https://localhost:5001/Teacher/Index
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return Content("Teacher controller Index Action");
            return View();
        }
    }
}
