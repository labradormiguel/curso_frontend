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
    public class FacturaController : Controller
    {
        private readonly ILogger<FacturaController> _logger;

        public FacturaController(ILogger<FacturaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return View();
        }

        public IActionResult Insertar(Factura factura)
        {
            // inserto y después de insertar vuelvo a mostrar el listado
            FacturaRepositorio.Insertar (factura);
            //ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return RedirectToAction("Index","Factura"); // Factura se pone si se quiere cambiar a otro controlador
            //return RedirectToAction("Index");
        }

        public IActionResult Borrar(int numero)
        {
            FacturaRepositorio.Borrar(numero);
            //ViewBag.ListaFacturas = FacturaRepositorio.BuscarTodos();
            return RedirectToAction("Index");
        }

        public IActionResult Detalle(int numero)
        {
            ViewBag.Factura = FacturaRepositorio.BuscarUna(numero);

            /*
            ViewBag.nombre = factura.Nombre;
            ViewBag.importe = factura.Importe;
            ViewBag.tipoiva = factura.TipoIVA;
            ViewBag.pagada = factura.Pagada;*/
            return View();
        }

        /*
        public IActionResult ListaFacturas()
        {
            ViewBag.ListaFacturas = FacturaRepositorio.lista;
            return View();
        }*/
        public IActionResult Formulario()
        {
            return View();
        }
    }
}
