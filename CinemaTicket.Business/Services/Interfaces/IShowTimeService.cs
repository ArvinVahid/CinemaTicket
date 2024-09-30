﻿using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services.Interfaces
{
    public interface IShowTimeService : IBaseService<ShowTime>
    {
        bool IsShowTimeExists(int id);
        List<Cinema> CinemasFromMovie(int movieId);
        List<CinamaSanse> CinemasFromMovie(string movieName);
        List<MovieSans> MoviesFromCinema(int cinemaId);
        List<MovieSans> MoviesFromCinema(string cinemaName);
    }
}
