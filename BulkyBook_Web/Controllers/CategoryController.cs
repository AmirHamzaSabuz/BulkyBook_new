﻿using Microsoft.AspNetCore.Mvc;

namespace BulkyBook_Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
