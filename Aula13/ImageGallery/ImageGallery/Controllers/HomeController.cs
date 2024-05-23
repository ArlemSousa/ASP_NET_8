using ImageGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ImageGallery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //obter çlista de arquivos de imagens
            var imgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img");
            var imageFiles = Directory.EnumerateFiles(imgPath).Select(Path.GetFileName).ToList();

            //passar a lista para arquivos de imagens através da view
            ViewBag.Images = imageFiles;

            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
