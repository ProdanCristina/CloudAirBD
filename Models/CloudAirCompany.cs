using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class CloudAirCompany
    {
        public int CloudAirCompanyId { get; set; }
        public string Nume { get; set; }

        public ICollection<Booking> Booking { get; set; }

    }
}
