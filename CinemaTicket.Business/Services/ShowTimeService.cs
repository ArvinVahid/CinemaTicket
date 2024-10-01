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
    public class ShowTimeService : BaseService<ShowTime, IShowTimeRepo>, IShowTimeService
    {
        public ShowTimeService(IShowTimeRepo repo) : base(repo)
        {
        }

        public List<Cinema> CinemasFromMovie(int movieId)
        {
            return _repo.CinemasFromMovie(movieId);
        }

        public List<CinamaSanse> CinemasFromMovie(string movieName)
        {
            return _repo.CinemasFromMovie(movieName);
        }

        public bool IsShowTimeExists(int id)
        {
            return _repo.IsShowTimeExists(id);
        }

        public List<MovieSans> MoviesFromCinema(int cinemaId)
        {
            return _repo.MoviesFromCinema(cinemaId);
        }

        public List<MovieSans> MoviesFromCinema(string cinemaName)
        {
            return _repo.MoviesFromCinema(cinemaName);
        }
    }
}
