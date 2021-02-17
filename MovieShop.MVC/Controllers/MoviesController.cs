using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieShop.Infrastructure.Services;
using MovieShop.Core.ServiceInterfaces;

namespace MovieShop.MVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //look for action methods instead of view name. we can change default view by returning view("custom view")
        public ActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TopRevenueMovies()
        {
            var movies = _movieService.GetHighestGrossingMovies();
            return View(movies);
        }
        [HttpGet]
        public IActionResult TopRatedMovies()
        {
            return View();
        }
        [HttpGet("{id}")]
        public IActionResult Genre(int id)
        {
            return View();
        }
        [HttpGet]
        public IActionResult AllReviews()
        {
            return View();
        }
        [HttpGet("{id}")]
        public IActionResult Reviews(int id)
        {
            return View();
        }
    }
}
