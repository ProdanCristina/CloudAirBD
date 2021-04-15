using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Suject { get; set; }
        public string Message { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
