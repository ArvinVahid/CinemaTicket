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
    public class CinemaRepo : BaseRepo<Cinema>, ICinemaRepo
    {
        public CinemaRepo(DataContext context) : base(context)
        {
        }

        public Cinema GetCinemaByName(string name)
        {
            return Query.FirstOrDefault(c => c.Name == name);
        }

        public bool IsCinemaExists(int id)
        {
            return Query.Any(c => c.Id == id);
        }
    }
}
