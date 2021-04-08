using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string People { get; set; }
        public string Message { get; set; }

        public ICollection<Ticket> Ticket { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CloudAirCompanyID { get; set;}

        public CloudAirCompany CoudAirCompany {get;set;}


        

    }
}
