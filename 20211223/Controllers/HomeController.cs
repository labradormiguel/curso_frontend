using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_ajax.Models;


namespace mvc_ajax.Controllers
{
    public class HomeController : Controller
    {

        static List<string> textos = new List<string>();
        static HomeController()
        {
            textos.Add("hola");
            textos.Add("qué");
            textos.Add("tal");
            textos.Add("estás");
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.textos = textos;
            return View();
        }

        public IActionResult ListaFacturas()
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            ViewBag.listafacturas = repo.BuscarTodas();
            return View();
        }

        public IActionResult ListaClientes(string nombre)
        {
            Console.WriteLine(nombre);
            if (nombre != null)
            {

                ClienteRepositorio repo = new ClienteRepositorio();
                List<Cliente> clientes = repo.BuscarTodasPorNombre(nombre);
                Console.WriteLine(clientes.Count);
                ViewBag.listaclientes = clientes;

                return View();
            }
            else
            {
                ClienteRepositorio repo = new ClienteRepositorio();
                ViewBag.listaclientes = repo.BuscarTodas();
                return View();

            }

        }

        public IActionResult FormularioBorrar()
        {
            return View();
        }

        public IActionResult FormularioEditar()
        {
            return View();
        }

        public JsonResult ListaClientesJSON(string nombre)
        {
            ClienteRepositorio repo = new ClienteRepositorio();
            List<Cliente> lista;

            if (nombre != null)
            {
                lista = repo.BuscarTodasPorNombre(nombre);
            }
            else
            {
                lista = repo.BuscarTodas();
            }

            return Json(lista);
        }

        public JsonResult ListaFacturasJSON()
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            List<Factura> lista = repo.BuscarTodas();

            return Json(lista);
        }

        public IActionResult ListaPersonas()
        {
            PersonaRepositorio repo = new PersonaRepositorio();
            ViewBag.listapersonas = repo.BuscarTodas();
            return View();
        }

        public IActionResult Insertar(Cliente cliente)
        {
            ClienteRepositorio repo = new ClienteRepositorio();
            repo.Insertar(cliente);

            ViewBag.listapersonas = repo.BuscarTodas();
            return RedirectToAction("ListaClientes");
        }

        [HttpPost]
        public IActionResult InsertarJSON([FromBody] Cliente cliente)
        {
            Console.WriteLine(cliente.Dni);
            Console.WriteLine(cliente.Nombre);
            Console.WriteLine(cliente.Apellido);
            ClienteRepositorio repo = new ClienteRepositorio();
            repo.Insertar(cliente);
            return Json("Success");
        }

        public JsonResult ListaPersonasJSON()
        {
            PersonaRepositorio repo = new PersonaRepositorio();
            List<Persona> lista = repo.BuscarTodas();

            return Json(lista);
        }

        public JsonResult ListaFacturasPorConcepto(string concepto)
        {
            FacturaRepositorio repo = new FacturaRepositorio();
            List<Factura> lista;

            if (concepto != null)
            {
                lista = repo.BuscarTodasPorConcepto(concepto);
            }
            else
            {
                lista = repo.BuscarTodas();
            }

            return Json(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public ActionResult Datos()
        {
            return Content("tú");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
