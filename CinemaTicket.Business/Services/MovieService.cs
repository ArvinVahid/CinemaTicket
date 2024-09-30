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
    public class MovieService : BaseService<Movie, IMovieRepo>, IMovieService
    {
        public MovieService(IMovieRepo repo) : base(repo)
        {
        }

        public List<Movie> GetAll()
        {
            return _repo.GetAll();
        }

        public Movie GetMovieById(int id)
        {
            return _repo.GetEntityById(id);
        }

        public Movie GetMovieByName(string name)
        {
            return _repo.GetMovieByName(name);
        }

        public void Insert(Movie entity)
        {
            _repo.Insert(entity);
        }

        public bool IsMovieExists(int id)
        {
            return _repo.IsMovieExists(id);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }

        public void Update(Movie entity)
        {
            _repo.Update(entity);
        }
    }
}
