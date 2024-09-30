using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicket.Business.Entities
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int MovieLength { get; set; }
        public byte Rate { get; set; }
    }
}
