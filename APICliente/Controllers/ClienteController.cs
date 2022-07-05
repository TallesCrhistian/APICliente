using APICliente.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICliente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody]Cliente cliente)
        {
            cliente.Id = id++;
            clientes.Add(cliente);
            Console.WriteLine(cliente.Cpf);
            return CreatedAtAction(nameof(RetornaClientePorId), new { Id = cliente.Id }, cliente);

        }

        [HttpGet]
        public IActionResult RecuperarCliente()
        {
            return Ok(clientes);
        }
        [HttpGet("{id}")]
        public IActionResult RetornaClientePorId(int id)
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            Cliente cliente = clientes.FirstOrDefault(cliente => cliente.Id == id);
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            if (cliente != null)
            {
                return Ok(cliente);
            }
            return NotFound();
        }

    }
}
