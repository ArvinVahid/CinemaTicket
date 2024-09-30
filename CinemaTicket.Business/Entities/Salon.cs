using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class Salon : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }
        public ICollection<Seat> Seats { get; set; }

    }
}
