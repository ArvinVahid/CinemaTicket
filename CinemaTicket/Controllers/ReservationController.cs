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
        private readonly IReservedSeatService _reservedSeatService;
        public ReservationController(IReservationService reservationService, IReservedSeatService reservedSeatService)
        {
            _reservationService = reservationService;
            _reservedSeatService = reservedSeatService;
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
                NumberOfTickets = dto.SeatsId.Count,
                ReservationDate = DateTime.Now,
                TotalPrice = dto.NumberOfTickets * _reservationService.GetShowTimePrice(dto.ShowTimeId),
            };

            _reservationService.Insert(reservation);

            foreach (var item in dto.SeatsId)
            {
                ReservedSeat reserved = new ReservedSeat
                {
                    ReservationId = reservation.Id,
                    SeatId = item
                };
                _reservedSeatService.Insert(reserved);
            }


            return Ok($"Your reservation Id is {reservation.Id}");
        }

        [HttpGet("GetTotalReservationCountPerMovieId")]
        public ActionResult GetTotalReservationCountPerMovie(int movieId)
        {
            return Ok(_reservationService.GetTotalReservationCountPerMovie(movieId));
        }

        [HttpGet("GetTotalReservationCountPerMovieName")]
        public ActionResult GetTotalReservationCountPerMovie(string movieName)
        {
            return Ok(_reservationService.GetTotalReservationCountPerMovie(movieName));
        }

        [HttpGet("GetTotalCustomersOfCinemaById")]
        public ActionResult GetTotalCustomersOfCinemaById(int cinemaId)
        {
            return Ok(_reservationService.GetTotalCustomersOfCinema(cinemaId));
        }

        [HttpGet("GetTotalCustomersOfCinemaByName")]
        public ActionResult GetTotalCustomersOfCinemaByName(string cinemaName)
        {
            return Ok(_reservationService.GetTotalCustomersOfCinema(cinemaName));
        }

        [HttpGet("GetMostViewedCinema")]
        public ActionResult GetMostViewedCinema()
        {
            return Ok(_reservationService.GetMostViewedCinema());
        }
    }
}
