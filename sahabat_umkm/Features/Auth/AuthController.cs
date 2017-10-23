using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sahabat_umkm.Models;

namespace sahabat_umkm.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            ViewData["SubTitle"] = "Login Administrator";

            return View();
        }
    }
}