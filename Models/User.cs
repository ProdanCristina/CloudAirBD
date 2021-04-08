using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }

        public ICollection<Booking>Booking { get; set; }
        public ICollection<Ticket> Ticket { get; set; }

    }
}
