using CinemaTicket.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Services.Interfaces
{
    public interface IMovieService : IBaseService<Movie>
    {
        Movie GetMovieById(int id);
        Movie GetMovieByName(string name);
        bool IsMovieExists(int id);
    }
}
