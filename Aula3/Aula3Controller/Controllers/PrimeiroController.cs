using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Aula3Controller.Controllers
{
    public class PrimeiroController : Controller
    {
        public string Index()
        {
            return "Teste teste";
        }

        public string Second()
        {
            return string.Empty;
        }

        public IActionResult Welcome(string name, int idade = 30)
        {
            ViewData["Saudacao"] = "Olá " + name;
            ViewData["Idade"] = idade;

            return View();
            //return HtmlEncoder.Default.Encode($"Ola {name} repeticao {numTimes}");
        }

    }
}
