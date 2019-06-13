using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                 new Movie { Name = "Sherk" },
                 new Movie { Name = "Wall-e" },
                 new Movie { Name = "No pain no gain" },
                 new Movie { Name = "Avengers" }
            };

            var viewModel = new MovieViewModel
            {
                Movies = movies
  
            };

            return View(viewModel);

        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year+"/"+month);
        //}
    }
}