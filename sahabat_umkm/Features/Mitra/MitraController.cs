using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sahabat_umkm.Models;

namespace sahabat_umkm.Controllers
{
    public class MitraController : Controller
    {
        public IActionResult Registrasi()
        {
            ViewData["Title"] = "Sahabat UMKM";
            ViewData["SubTitle"] = "Registrasi Kemitraan";

            return View();
        }

        public IActionResult Daftar()
        {
            ViewData["Title"] = "Sahabat UMKM";
            ViewData["SubTitle"] = "Daftar Kemitraan";

            return View();
        }
    }
}