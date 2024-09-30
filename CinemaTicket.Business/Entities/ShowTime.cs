using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class ShowTime : BaseEntity
    {
        public int MovieId { get; set; }
        public int SalonId { get; set; }
        public DateTime ShowingTime { get; set; }
        public decimal Price { get; set; }

        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
    }
}
