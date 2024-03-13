using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;

        }

        [HttpGet]
        public ActionResult<List<MovieService>> Get()
        {
            return Ok(_movieService.GetAllMovies());
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _movieService.CreateMovie(movie);
            return Ok(movie);
        }

    }
}
