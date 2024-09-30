using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class CinemaToMovie
    {
        public int CinemaId { get; set; }
        public int MovieId { get; set; }

        public Cinema Cinema { get; set; }
        public Movie Movie { get; set; }
    }
}
