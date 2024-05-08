using Microsoft.AspNetCore.Mvc;

namespace MVCComTopLevel.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saudacao()
        {
            return View();
        }
    }
}
