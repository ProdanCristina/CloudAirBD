using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int Price { get; set; }

        public int BookigId { get; set; }
        public Reserve Booking { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
