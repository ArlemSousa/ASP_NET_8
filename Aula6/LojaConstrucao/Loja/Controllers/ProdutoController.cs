using Loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class ProdutoController : Controller
    {
        //criar a lista de produtos
        private static List<Produto> _produtos = new List<Produto>()
        {
            new Produto {Id = 1, Nome = "Celular",  Descricao = "Samsung Galaxy S23", Preco = 1000},
            new Produto {Id = 2, Nome = "Notebook", Descricao = "Samsung Galaxy Book", Preco = 2000},
            new Produto {Id = 3, Nome = "Tablet",   Descricao = "Samsung Galaxy Tab S9", Preco = 2000},
            new Produto {Id = 4, Nome = "Arcondicionado", Descricao = "Samsung WindFree", Preco = 3000},

        };

        //passar a lista de produtos para a view\cliente\index
        public IActionResult Index()
        {
            return View(_produtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Produto produto)
        {
            if (ModelState.IsValid)
            {

                produto.Id = _produtos.Count > 0 ? _produtos.Max(x => x.Id) : 0;
                _produtos.Add(produto);

                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
