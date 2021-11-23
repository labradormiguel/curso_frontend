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
    public class FacturaController : Controller
    {
        private readonly ILogger<FacturaController> _logger;

        public FacturaController(ILogger<FacturaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerFactura(Factura factura)
        {
            ViewBag.numero = factura.Numero;
            ViewBag.nombre = factura.Nombre;
            ViewBag.importe = factura.Importe;
            return View();
        }
    }
}
