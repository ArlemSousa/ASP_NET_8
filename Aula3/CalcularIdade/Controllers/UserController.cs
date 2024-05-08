using CalcularIdade.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Xml.Linq;

namespace CalcularIdade.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalcularIdade(User user)
        {
            int idade = DateTime.Now.Year - user.DataNascimento.Year;
            if (DateTime.Now < user.DataNascimento.AddYears(idade)) idade--;

            //ViewData["Saudacao"] = "Olá Sua idade é" + idade;

            ViewBag.Idade = idade;

            return View("Resultado");
        }

    }
}
