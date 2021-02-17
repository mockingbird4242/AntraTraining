using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.RepositoryInterfaces;
using MovieShop.Core.Entities;
using MovieShop.Infrastructure.Data;
using System.Linq;

namespace MovieShop.Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Movie> GetTopRevenueMovies()
        {
            return _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(20);
        }

        public IEnumerable<Movie> GetHighestRatedMovies()
        {
            var movies = new List<Movie>
            {
                new Movie {Id = 10, Title = "The Dark Knight", Budget = 1200000},
                new Movie {Id = 11, Title = "The Hunger Games", Budget = 1200000},
                new Movie {Id = 12, Title = "Django Unchained", Budget = 1200000},
                new Movie {Id = 14, Title = "Harry Potter and the Philosopher's Stone", Budget = 1200000},
                new Movie {Id = 15, Title = "Iron Man", Budget = 1200000},
                new Movie {Id = 16, Title = "Furious 7", Budget = 1200000}
            };
            return movies;
        }

        public IEnumerable<Movie> GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }
        public override Movie GetByIdAsync(int id)
        {
            return _dbContext.Movies.FirstOrDefault(mbox => mbox.Id == id);
        }
    }
}
