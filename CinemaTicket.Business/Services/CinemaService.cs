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
    public class CinemaService : BaseService<Cinema, ICinemaRepo>, ICinemaService
    {
        public CinemaService(ICinemaRepo repo) : base(repo)
        {
        }

        public Cinema GetCinemaByName(string name)
        {
            return _repo.GetCinemaByName(name);
        }

        public bool IsCinemaExists(int id)
        {
            return _repo.IsCinemaExists(id);
        }
    }
}
