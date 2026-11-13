using EF_Core_02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Contexts
{
    public class EventHubDbContext : DbContext
    {
        public EventHubDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EventHubDB ; Trusted_Connection = true; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



            #region Badge Configurautions

            // Primary key and the date issued are required by convention automatically

            // now i want to apply constraint so that the tier values are ---> Standard or VIP

            // I dont know u mean to make constraint to control this or not 



            // The relation ship by fluent API between the attendee and the badge 

            modelBuilder.Entity<Badge>()
                .HasOne(B => B.Attendee)
                .WithOne(A => A.Badge)
                .HasForeignKey<Badge>(B => B.AttendeeId);
            #endregion
        }


        // ana haraye7 dmaaghy 
        // Create dbSet for all classes i dont remember which Convention ,  Data Annotation or FluentApi

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }


    }
}
