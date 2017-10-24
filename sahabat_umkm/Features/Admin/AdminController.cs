using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sahabat_umkm.Models;

namespace sahabat_umkm.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            ViewData["SubTitle"] = "Login Administrator";

            return View("Index");
        }

        public IActionResult FormAgama()
        {
            ViewData["Title"] = "Manage Data";
            ViewData["Subtitle"] = "Data Agama";
            return View();
        }
    }
}