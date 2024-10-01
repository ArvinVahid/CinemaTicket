using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _seatService;
        public SeatController(ISeatService seatService)
        {
            _seatService = seatService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Seat>> GetAllSeats()
        {
            return _seatService.GetAll();
        }


        [HttpGet("GetById")]
        public ActionResult<Seat> GetSeatById(int id)
        {
            return _seatService.GetEntityById(id);
        }

        [HttpPost("Insert")]
        public IActionResult InsertSeat(Seat seat)
        {
            if (!_seatService.IsSeatExists(seat.Id))
            {
                _seatService.Insert(seat);
                return Ok();
            }
            return NoContent();
        }

        [HttpPut("Update")]
        public IActionResult UpdateSeat(Seat seat)
        {
            if (_seatService.IsSeatExists(seat.Id))
            {
                _seatService.Update(seat);
                return Ok();
            }
            return NoContent();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteSeat(int id)
        {
            if (_seatService.IsSeatExists(id))
            {
                _seatService.Remove(id);
                return Ok();
            }
            return NoContent();
        }
    }
}
