using CinemaTicket.Business.Entities;
using CinemaTicket.Business.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Data.Repo
{
    public class MovieRepo : BaseRepo<Movie>, IMovieRepo
    {
        public MovieRepo(DataContext context) : base(context)
        {
        }

        public Movie GetMovieByName(string name)
        {
            return Query.FirstOrDefault(m => m.Name == name);
        }

        public bool IsMovieExists(int id)
        {
            return Query.Any(m => m.Id == id);
        }
    }
}
