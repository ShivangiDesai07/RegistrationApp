using Microsoft.EntityFrameworkCore;
using RegistrationApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationApp.DbContexts
{
    public class RegistrationContext : DbContext
    {
        public RegistrationContext(DbContextOptions<RegistrationContext> options)
           : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<UsersDetail> UsersDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                 .HasData(
                new Client()
                {
                    ClientId = 1,
                    ClientName = "Mr Green",
                    ClientCode = "MrGreen",
                    ClientDesc = "Mr Green",
                    ClientIsActive = true,
                    ClientCreatedOn = DateTime.Now
                },
                new Client()
                {
                    ClientId = 2,
                    ClientName = "Red Bat",
                    ClientCode = "RedBat",
                    ClientDesc = "Red Bat",
                    ClientIsActive = true,
                    ClientCreatedOn = DateTime.Now
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
