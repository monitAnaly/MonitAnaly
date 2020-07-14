using Data.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Models.Context
{
    public class MonitContext : DbContext
    {
        private static string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MonitAdminstrator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MonitContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Error> errors { get; set; }
        public DbSet<Account> accounts { get; set; }
        //public DbSet<License> licenses { get; set; }
    }
}
