using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;
        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Cinema>> GetAllCinemas()
        {
            return _cinemaService.GetAll();
        }

        [HttpGet("GetById")]
        public ActionResult<Cinema> GetCinemaById(int id)
        {
            return _cinemaService.GetEntityById(id);
        }

        [HttpGet("GetByName")]
        public ActionResult<Cinema> GetCinemaByName(string name)
        {
            return _cinemaService.GetCinemaByName(name);
        }

        [HttpPost("Insert")]
        public ActionResult InsertCinema(Cinema cinema)
        {
            if (!_cinemaService.IsCinemaExists(cinema.Id))
            {
                _cinemaService.Insert(cinema);
                return Ok(cinema);
            }
            return NoContent();
        }

        [HttpPut("Update")]
        public IActionResult UpdateCinema(Cinema cinema)
        {
            if (_cinemaService.IsCinemaExists(cinema.Id))
            {
                _cinemaService.Update(cinema);
                return Ok(cinema);
            }
            return NoContent();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteCinema(int id)
        {
            if (_cinemaService.IsCinemaExists(id))
            {
                _cinemaService.Remove(id);
                return Ok();
            }
            return NoContent();
        }
    }
}
