using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TMDBApi.Models;

namespace TMDBApi.Services
{
    public class TmdbService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "e1f33ad3cbd6b17f8f11b9534d5ba10c";

        public TmdbService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Genre>> GetGenresAsync()
        {
            var response = await _httpClient.GetStringAsync($"https://api.themoviedb.org/3/genre/movie/list?api_key={_apiKey}&language=pt-BR");
            var genres = JsonConvert.DeserializeObject<GenreResponse>(response);
            return genres.Genres;
        }

        public async Task<List<Movie>> SearchMoviesAsync(string query, int? genreId, int? year)
        {
            var url = $"https://api.themoviedb.org/3/search/movie?api_key={_apiKey}&language=pt-BR&query={query}";
            if (genreId.HasValue)
            {
                url += $"&with_genres={genreId.Value}";
            }
            if (year.HasValue)
            {
                url += $"&year={year.Value}";
            }
            var response = await _httpClient.GetStringAsync(url);
            var movies = JsonConvert.DeserializeObject<MovieResponse>(response);
            return movies.Results;
        }
    }
}
