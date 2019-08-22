using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index()
        {
            //var movies = new List<Movie>()
            //{
            //    new Movie() { Id = 1, Name = "Shrek!" },
            //    new Movie() { Id = 2, Name = "Wall-e" }
            //};

            var movies = _context.Movies.Include(m => m.GenreType).ToList();

            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,  int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.GenreType).FirstOrDefault(m => m.Id == Id);

            return View(movie);
        }
    }    
}