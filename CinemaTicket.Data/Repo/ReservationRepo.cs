using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class ReservationRepo : BaseRepo<Reservation>, IReservationRepo
    {
        public ReservationRepo(DataContext context) : base(context)
        {
        }

        public string GetMostViewedCinema()
        {
             return Query.Include(x => x.ShowTime)
                        .ThenInclude(x => x.Salon)
                        .ThenInclude(x => x.Cinema)
                        .OrderBy(x => x.NumberOfTickets)
                        .Select(x => x.ShowTime.Salon.Cinema.Name)
                        .FirstOrDefault();
        }

        public decimal GetShowTimePrice(int showTimeId)
        {
            return Query.Include(x => x.ShowTime)
                        .Where(x => x.ShowTime.Id == showTimeId)
                        .Select(x => x.ShowTime.Price)
                        .FirstOrDefault();
        }

        public int GetTotalCustomersOfCinema(int cinemaId)
        {
            return Query.Include(x => x.ShowTime)
                        .ThenInclude(x => x.Salon)
                        .Where(c => c.ShowTime.Salon.CinemaId == cinemaId)
                        .Sum(x => x.NumberOfTickets);
        }

        public int GetTotalCustomersOfCinema(string cinemaName)
        {
            return Query.Include(x => x.ShowTime)
                        .ThenInclude(x => x.Salon)
                        .ThenInclude(x => x.Cinema)
                        .Where(c => c.ShowTime.Salon.Cinema.Name == cinemaName)
                        .Sum(x => x.NumberOfTickets);
        }

        public int GetTotalReservationCountPerMovie(int movieId)
        {
            return Query.Include(x => x.ShowTime)
                        .Where(x => x.ShowTime.MovieId == movieId)
                        .Sum(x => x.NumberOfTickets);
        }

        public int GetTotalReservationCountPerMovie(string movieName)
        {
            return Query.Include(x => x.ShowTime)
                        .Where(x => x.ShowTime.Movie.Name == movieName)
                        .Sum(x => x.NumberOfTickets);
        }
    }
}
