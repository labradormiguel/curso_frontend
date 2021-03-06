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
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {

        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Cliente> Get()
        {

            ClienteRepositorio repo = new ClienteRepositorio();
            return repo.BuscarTodas();

        }

        [HttpPut("{dni}")]
        public void Salvar(string dni, Cliente cliente)
        {
            ClienteRepositorio repo = new ClienteRepositorio();
            repo.Salvar(cliente);
        }

        [HttpPost]
        public void Insertar(Cliente cliente)
        {

            ClienteRepositorio repo = new ClienteRepositorio();
            repo.Insertar(cliente);

        }

        [HttpDelete("{dni}")]
        public void Borrar(string dni)
        {

            ClienteRepositorio repo = new ClienteRepositorio();
            repo.Borrar(new Cliente(dni));

        }

        [HttpGet("{dni}")]
        public Cliente GetUno(string dni)
        {
            ClienteRepositorio repo = new ClienteRepositorio();
            return repo.BuscarUno(dni);
        }

    }
}
