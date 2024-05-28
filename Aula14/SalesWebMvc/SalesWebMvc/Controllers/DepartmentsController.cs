using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> departments = new List<Departments>();

            departments.Add(new Departments { DepartmentId = 1, Name = "Teste" });
            departments.Add(new Departments { DepartmentId = 2, Name = "Eletro" });
            departments.Add(new Departments { DepartmentId = 3, Name = "Moveis" });
            departments.Add(new Departments { DepartmentId = 4, Name = "Telefone" });

            return View(departments);
        }
    }
}
