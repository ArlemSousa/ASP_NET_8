using Microsoft.AspNetCore.Mvc;

namespace NavegacaoBasica.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
