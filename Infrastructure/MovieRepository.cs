using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>() { 
            new Movie{Id = 1, Name = "Duna", Cost = 2},
            new Movie{Id = 2, Name = "Kong", Cost = 3},
            new Movie{Id = 3, Name = "King", Cost = 1},

        };
        private readonly MovieDatabaseContext _movieContext;

        public MovieRepository(MovieDatabaseContext movieContext)
        {
            _movieContext = movieContext;
        }
  

        public Movie CreateMovie(Movie movie)
        {
            _movieContext.Movies.Add(movie);
            _movieContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieContext.Movies.ToList();
        }
    }
}
