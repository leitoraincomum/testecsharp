
using Microsoft.AspNetCore.Mvc;
using testeMuralis.Model;

namespace testeMuralis.Controllers
{
    [ApiController]
    [Route("/api/controller")]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> Clientes()
        {
            return new List<Cliente>{
                new Cliente{nome = "Fernanda", Id = 0, dataCadastro = DateTime.Now}
            };
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Clientes());
        }

        [HttpPost]
        public IActionResult Post(Cliente clientes)
        {
            var cliente = Clientes();
            cliente.Add(clientes);
            return Ok(cliente);
        }
        
    }
}