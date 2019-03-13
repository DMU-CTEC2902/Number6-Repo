using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.ViewModel
{
    public class MovieViewModel
    {
        public List<Movie> TopRatedMovies;
        public List<Movie> NewMovies;
        public List<Movie> UpComingMovies;
    }
}