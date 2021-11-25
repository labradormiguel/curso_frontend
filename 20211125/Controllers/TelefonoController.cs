using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net.Models;
using net.Models.Repositorios;

namespace net.Controllers
{
    public class TelefonoController : Controller
    {
        private readonly ILogger<TelefonoController> _logger;

        public TelefonoController(ILogger<TelefonoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ListaTelefonos = TelefonoRepositorio.BuscarTodos();
            return View();
        }

        public IActionResult Insertar(Telefono Telefono)
        {
            TelefonoRepositorio.Insertar(Telefono);
            return RedirectToAction("Index","Telefono");
        }

        public IActionResult Borrar(int id)
        {
            TelefonoRepositorio.Borrar(id);
            return RedirectToAction("Index","Telefono");
        }

        public IActionResult Formulario()
        {
            return View();
        }
    }
}
