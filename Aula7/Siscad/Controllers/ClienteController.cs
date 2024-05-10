using Microsoft.AspNetCore.Mvc;
using Siscad.Models;

namespace Siscad.Controllers
{
    public class ClienteController : Controller
    {

        private static List<Cliente> _cliente = new List<Cliente>()
        {
            new Cliente {IdCliente = 1, NomeCliente = "Teste", Email = "email@email.coim", Descricao = "teste teste"},
            new Cliente { IdCliente = 2, NomeCliente = "teste2", Email = "Email2", Descricao = "Teste2 teste2"}
        };



        public IActionResult Index()
        {
            return View(_cliente);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //atribui o novo id do cliente, que veio nulo
                cliente.IdCliente = _cliente.Count > 0 ? _cliente.Max(c => c.IdCliente) + 1 : 1;

                //adiciona o cliente na lista de clientes
                _cliente.Add(cliente);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var cliente = _cliente.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                return View(cliente);

            }
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            var existe = _cliente.FirstOrDefault(c => c.IdCliente == c.IdCliente);
            if (existe != null)
            {
                existe.NomeCliente = cliente.NomeCliente;
                existe.Email = cliente.Email;
                existe.Descricao = cliente.Descricao;

            }
            return RedirectToAction("Index");
        }

        //public ActionResult Delete(int id)
        //{
        //    var cliente = _cliente.FirstOrDefault(c => c.IdCliente == id);
        //    if (cliente == null)
        //    {
        //        return NotFound();
        //    }


        //    return View(cliente);

        //}

        public IActionResult Delete(int id)
        {
            var cliente = _cliente.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _cliente.Remove(cliente);
            return RedirectToAction("Index");

        }

        [HttpDelete]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _cliente.FirstOrDefault(c => c.IdCliente == id);
            if (cliente == null)
            {
                _cliente.Remove(cliente);
            }
            return View();

        }
    }
}
