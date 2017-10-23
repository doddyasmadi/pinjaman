using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sahabat_umkm.Models;

namespace sahabat_umkm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Beranda";
            ViewData["SubTitle"] = "Kabar Terbaru";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "Tentang Kami";
            ViewData["SubTitle"] = "Tentang Kami";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["SubTitle"] = "Hubungi Kami";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
