using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Movie>> GetAllMovies()
        {
            return _movieService.GetAll();
        }


        [HttpGet("GetById")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            return _movieService.GetMovieById(id);
        }

        [HttpGet("GetByName")]
        public ActionResult<Movie> GetMovieByName(string name)
        {
            return _movieService.GetMovieByName(name);
        }

        [HttpPost("Insert")]
        public IActionResult InsertMovie(Movie movie)
        {
            if (!_movieService.IsMovieExists(movie.Id))
            {
                _movieService.Insert(movie);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut("Update")]
        public IActionResult UpdateMovie(Movie movie)
        {
            if (_movieService.IsMovieExists(movie.Id))
            {
                _movieService.Update(movie);
                return Ok();
            }
            return NoContent();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteMovie(int id)
        {
            if (_movieService.IsMovieExists(id))
            {
                _movieService.Remove(id);
                return Ok();
            }
            return NoContent();
        }
    }
}
