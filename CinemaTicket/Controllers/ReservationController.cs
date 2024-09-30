using CinemaTicket.Business.Dto;
using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }


        [HttpGet("GetById")]
        public ActionResult<Reservation> GetReservationById(int id)
        {
            return _reservationService.GetEntityById(id);
        }

        [HttpPost("Submit")]
        public ActionResult SubmitReservation(ReservationDto dto)
        {
            var reservation = new Reservation
            {
                UserId = dto.UserId,
                ShowTimeId = dto.ShowTimeId,
                NumberOfTickets = dto.NumberOfTickets,
                ReservationDate = DateTime.Now,
                TotalPrice = dto.TotalPrice,
            };

            _reservationService.Insert(reservation);
            return Ok(reservation);
        }
    }
}
