using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services.Interfaces
{
    public interface IReservationService : IBaseService<Reservation>
    {
        decimal GetShowTimePrice(int showTimeId);
        int GetTotalReservationCountPerMovie(int movieId);
        int GetTotalReservationCountPerMovie(string movieName);
        int GetTotalCustomersOfCinema(int cinemaId);
        int GetTotalCustomersOfCinema(string cinemaName);
        string GetMostViewedCinema();

    }
}
