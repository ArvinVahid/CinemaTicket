using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class MovieSans
    {
        public string MovieName { get; set; }
        public int MovieId { get; set; }
        public int SansId { get; set; }
        public DateTime ShowTime { get; set; }
        public int SalonId { get; set; }
    }
}
