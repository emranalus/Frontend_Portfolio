﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_Core.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
