using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {

            var cliente = new List<Cliente> {

             new Cliente { Id = 1, Nome = "Francisco Mota", Email = "email@email.com" },
             new Cliente { Id = 2, Nome = "Lauane Mota", Email = "lauane@gmail.com" },
             new Cliente { Id = 3, Nome = "Caique", Email = "caique@hotmail.com" },
             new Cliente { Id = 4, Nome = "vagner", Email = "vagner@bol.com" }

            };

            ViewBag.Cliente = cliente;

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            //simulação da passagem de parametro de id para a busca de uma informação no bd
            var cliente = new Cliente { Id = id, Nome = "Cliente Teste", Email = "teste@Email.com" };
            
            return View(cliente);
        }

    }
}
