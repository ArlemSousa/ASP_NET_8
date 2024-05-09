using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class ClienteController : Controller
    {

        //criando uma lista de clientes
        //lembrar sempre que o nome de atributos private tem que começar com _ por boas praticas
        private static List<Cliente> _clientes = new List<Cliente>()
        {
            new Cliente {ClienteId = 1, NomeCliente = "Francisco Mota", Email = "Email@email.com"},
            new Cliente {ClienteId = 2, NomeCliente = "Lauane de Souza", Email = "Email@lauane.com"},
            new Cliente {ClienteId = 3, NomeCliente = "Cabo Daciolo", Email = "daciolo@cabo.com"},
            new Cliente {ClienteId = 4, NomeCliente = "Amanda Ventura", Email = "amandinha@ventura.com"},
            new Cliente {ClienteId = 5, NomeCliente = "Elisama", Email = "lih@sama.com"}
        };

        //Teste
        
        public IActionResult Index()
        {
            return View(_clientes);
        }

        public IActionResult Details() {
            return View();
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if(ModelState.IsValid) {
                
                //atribui o novo id do cliente, que veio nulo
                cliente.ClienteId = _clientes.Count > 0 ? _clientes.Max(c => c.ClienteId) + 1 : 1;
                
                //adiciona o cliente na lista de clientes
                _clientes.Add(cliente);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
