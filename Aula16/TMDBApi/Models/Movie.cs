﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDBApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; } // Adicione esta linha
    }

    public class MovieResponse
    {
        [JsonProperty("results")]
        public List<Movie> Results { get; set; }
    }
}
