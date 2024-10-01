using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using CinemaTicket.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services
{
    public class ReservationService : BaseService<Reservation, IReservationRepo>, IReservationService
    {
        public ReservationService(IReservationRepo repo) : base(repo)
        {
        }

        public string GetMostViewedCinema()
        {
            return _repo.GetMostViewedCinema();
        }

        public decimal GetShowTimePrice(int showTimeId)
        {
            return _repo.GetShowTimePrice(showTimeId);
        }

        public int GetTotalCustomersOfCinema(int cinemaId)
        {
            return _repo.GetTotalCustomersOfCinema(cinemaId);
        }

        public int GetTotalCustomersOfCinema(string cinemaName)
        {
            return _repo.GetTotalCustomersOfCinema(cinemaName);
        }

        public int GetTotalReservationCountPerMovie(int movieId)
        {
            return _repo.GetTotalReservationCountPerMovie(movieId);
        }

        public int GetTotalReservationCountPerMovie(string movieName)
        {
            return _repo.GetTotalReservationCountPerMovie(movieName);
        }
    }
}
