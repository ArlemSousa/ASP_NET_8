using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TMDBApi.Models;
using TMDBApi.Services;

namespace TMDBApi.Controllers
{
    public class MoviesController : Controller
    {
        private readonly TmdbService _tmdbService;

        public MoviesController(TmdbService tmdbService)
        {
            _tmdbService = tmdbService;
        }

        public async Task<IActionResult> Index()
        {
            var genres = await _tmdbService.GetGenresAsync();
            return View(genres); // Certifique-se de que os gêneros estão sendo passados para a view
        }

        [HttpPost]
        public async Task<IActionResult> Search(string query, int? genreId, int? year)
        {
            var movies = await _tmdbService.SearchMoviesAsync(query, genreId, year);
            return View(movies);
        }
    }
}
