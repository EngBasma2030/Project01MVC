﻿using Microsoft.AspNetCore.Mvc;

namespace Project01MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
