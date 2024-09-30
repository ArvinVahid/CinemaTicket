using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class Cinema : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public byte Rate {get; set; }
        public int ReservationCount { get; set; }

        public ICollection<Salon> Salons { get; set; }
    }
}
