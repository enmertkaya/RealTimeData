﻿using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
