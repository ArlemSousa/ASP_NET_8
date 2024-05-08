using Microsoft.AspNetCore.Mvc;

namespace NavegacaoBasica.Controllers
{
    public class ProdutoController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
