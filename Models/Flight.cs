using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int people { get; set; }
        public int CloudAirCompanyID { get; set; }

        public CloudAirCompany CoudAirCompany { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }



    }
}
