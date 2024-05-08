using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {

            var produto = new List<Produto> {

                new Produto {Id = 1, NomeProduto = "Notebook Asus", Descricao = "16 de Ram / Core I7", Preco = 2500, Quantidade = 10 },
                new Produto {Id = 1, NomeProduto = "Notebook Acer", Descricao = "16 de Ram / Core I5", Preco = 2500, Quantidade = 8 },
                new Produto {Id = 1, NomeProduto = "Notebook CCE", Descricao = "16 de Ram / Core I3", Preco = 2500, Quantidade = 9 },
                new Produto {Id = 1, NomeProduto = "Notebook Samsung", Descricao = "16 de Ram / Core I9", Preco = 2500, Quantidade = 7 },
                new Produto {Id = 1, NomeProduto = "Notebook Lenovo", Descricao = "16 de Ram / Ryzen 5", Preco = 2500, Quantidade = 15 }
            };

            ViewBag.Produto = produto;

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            //simulação da passagem de parametro de id para a busca de uma informação no bd
            var produto = new Produto { Id = 1, NomeProduto= "Produto Teste", Descricao= "Notebok com defeito", Quantidade = 1, Preco = 2100 };

            return View(produto);
        }
    }
}
