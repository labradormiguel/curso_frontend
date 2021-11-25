using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net.Models;

namespace net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult VerNota(int nota)
        {
            // Viewbag como su nombre indica
            // es una bolsa de intercambio de información
            // entre el controlador y la vista
            ViewBag.Nota=nota;
            return View();
        }

        public IActionResult Mensaje()
        {
            ViewBag.Nombre = "Mensaje de alguien";
            return View();
        }

        public IActionResult Sumar()
        {
            return View();
        }

        public IActionResult CienNumeros()
        {
            return View();
        }

        public IActionResult VerSuma(int n1, int n2)
        {
            int Suma = n1 + n2;
            ViewBag.Suma = Suma;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
