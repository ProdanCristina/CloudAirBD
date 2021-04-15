using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{
   
        public class CloudAirCompanyContext : DbContext
        {
            public CloudAirCompanyContext(DbContextOptions<CloudAirCompanyContext> options)
                : base(options)
            {

            }

            public DbSet<Reserve>Reserves { get; set; }

            public DbSet<CloudAirCompany> CloudAirCompanies { get; set; }

            public DbSet<User> Users { get; set; }

            public DbSet<Ticket> Tickets { get; set; }
            public DbSet<Flight> Flights { get; set; }
            public DbSet<Contact> Contacts { get; set; }
    }
    }

