using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monit.Models.Data
{
    public class AdmContext : DbContext
    {
        public AdmContext(DbContextOptions<AdmContext> options) : base(options)
        {

        }

        public DbSet<Error> errors { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<License> licenses { get; set; }
    }
}
