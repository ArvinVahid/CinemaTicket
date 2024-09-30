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
    public class ShowTimeRepo : BaseRepo<ShowTime>, IShowTimeRepo
    {
        public ShowTimeRepo(DataContext context) : base(context)
        {
        }

        public bool IsShowTimeExists(int id)
        {
            return Query.Any(x => x.Id == id);
        }

        public List<Cinema> CinemasFromMovie(int movieId)
        {
            return Query.Where(x => x.MovieId == movieId)
               .Include(s => s.Salon)
               .Select(x => x.Salon.Cinema).ToList();
        }

        public List<CinamaSanse> CinemasFromMovie(string movieName)
        {
            return Query.Include(m => m.Movie)
                        .Include(s => s.Salon)
                        .Where(m => m.Movie.Name == movieName)
                        .Where(s => s.Salon.Id == s.SalonId)
                        .Select(m => new CinamaSanse
                        {
                            CinemaId = m.Salon.CinemaId,
                            CinemaName = m.Salon.Cinema.Name,
                            SanseId = m.Id,
                            ShowTime = m.ShowingTime,
                            SalonId = m.SalonId
                        }).ToList();
        }

        public List<MovieSans> MoviesFromCinema(int cinemaId)
        {
            return Query.Include(x => x.Salon.Cinema)
                        .Where(x => x.Salon.CinemaId == cinemaId)
                        .Select(x => new MovieSans
                        {
                            MovieId = x.MovieId,
                            MovieName = x.Movie.Name,
                            SalonId = x.SalonId,
                            SansId = x.Id,
                            ShowTime = x.ShowingTime,
                        }).ToList();
        }

        public List<MovieSans> MoviesFromCinema(string cinemaName)
        {
            return Query.Include(x => x.Salon.Cinema)
                        .Where(x => x.Salon.Cinema.Name == cinemaName)
                        .Select(x => new MovieSans
                        {
                            MovieId = x.MovieId,
                            MovieName = x.Movie.Name,
                            SalonId = x.SalonId,
                            SansId = x.Id,
                            ShowTime = x.ShowingTime,
                        }).ToList();
        }
    }
}
