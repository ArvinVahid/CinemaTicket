using CinemaTicket.Business.Dto;
using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController : ControllerBase
    {
        private readonly IShowTimeService _showTimeService;
        public ShowTimeController(IShowTimeService showTimeService)
        {
            _showTimeService = showTimeService;
        }

        [HttpGet("GetById")]
        public ActionResult GetShowTime(int id)
        {
            return Ok(_showTimeService.GetEntityById(id));
        }

        [HttpGet("GetAll")]
        public ActionResult<List<ShowTime>> GetAllShowTimes()
        {
            return _showTimeService.GetAll();
        }

        [HttpPost("Insert")]
        public ActionResult InsertShowTime(ShowTimeInsertDto dto)
        {
            var showTime = new ShowTime
            {
                MovieId = dto.MovieId,
                SalonId = dto.SalonId,
                ShowingTime = dto.ShowingTime,
                Price = dto.Price
            };

            _showTimeService.Insert(showTime);
            return Ok(showTime);
        }

        [HttpPut("Update")]
        public IActionResult UpdateShowTime(ShowTimeInsertDto dto)
        {
            var showTime = new ShowTime
            {
                MovieId = dto.MovieId,
                SalonId = dto.SalonId,
                ShowingTime = dto.ShowingTime,
                Price = dto.Price
            };

            _showTimeService.Update(showTime);
            return Ok();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteMovie(int id)
        {
            if (_showTimeService.IsShowTimeExists(id))
            {
                _showTimeService.Remove(id);
                return Ok();
            }
            return NoContent();
        }

        [HttpGet("CinemasFromMovie")]
        public ActionResult GetCinemasFromMovie(int movieId)
        {
            return Ok(_showTimeService.CinemasFromMovie(movieId));
        }

        [HttpGet("CinemasFromMovieByName")]
        public ActionResult GetCinemasFromMovie(string movieName)
        {
            return Ok(_showTimeService.CinemasFromMovie(movieName));
        }

        [HttpGet("MoviesFromCinema")]
        public ActionResult GetMoviesFromCinema(int cinemaId)
        {
            return Ok(_showTimeService.MoviesFromCinema(cinemaId));
        }

        [HttpGet("MoviesFromCinemaByName")]
        public ActionResult GetMoviesFromCinema(string cinemaName)
        {
            return Ok(_showTimeService.MoviesFromCinema(cinemaName));
        }
    }
}
