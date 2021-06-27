using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using firstWebapp.Models;
using firstWebapp.ViewModels;

namespace firstWebapp.Controllers
{
    public class MoviesController: Controller
    {
        public ActionResult Index(){

            var movies = GetMovies();

            var viewModel = new MoviesViewModel{
                Movies = movies
            };

            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies(){
            return new List <Movie>{
                new Movie { Name = "Shrek"},
                new Movie { Name = "Wall-e"}
            };
        }
    }
}