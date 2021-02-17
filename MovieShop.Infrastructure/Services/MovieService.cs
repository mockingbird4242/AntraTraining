using MovieShop.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterfaces;

namespace MovieShop.Infrastructure.Services
{
    public class MovieService :IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public IEnumerable<Movie> GetHighestGrossingMovies()
        {
            var movies = _movieRepository.GetTopRevenueMovies();
            return movies;

        }
    }

}
