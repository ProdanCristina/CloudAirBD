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

            public DbSet<Booking> Bookings { get; set; }

            public DbSet<CloudAirCompany> CloudAirCompanies { get; set; }

            public DbSet<User> Users { get; set; }

            public DbSet<Ticket> Tickets { get; set; }
        }
    }

