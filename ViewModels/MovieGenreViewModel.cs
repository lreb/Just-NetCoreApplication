using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using justtest.Models;

namespace justtest.ViewModels
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}