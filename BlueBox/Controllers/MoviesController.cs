using BlueBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlueBox.ViewModels;

namespace BlueBox.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movies() { Title = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "William"},
                new Customer { Name = "Bob"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewModel);
        }

        public ActionResult MovieList()
        {

            IEnumerable<Movies> movieList = ViewMovies();

            return View(movieList);
        }

        private IEnumerable<Movies> ViewMovies()
        {
            List<Movies> movieList = new List<Movies>
            {
                new Movies { Id=1, Title="Battlefield: Earth"},
                new Movies { Id=2, Title="Twins"}
            };

            return movieList;
        }
    }
}