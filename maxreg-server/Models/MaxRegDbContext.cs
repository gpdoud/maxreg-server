using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using maxreg_server.Models;

namespace maxreg_server.Models
{
    public class MaxRegDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Guest> Guests { get; set; } 
        public DbSet<User> Users { get; set; }

        public MaxRegDbContext(DbContextOptions<MaxRegDbContext> context) : base(context)
        {

        }

        public DbSet<maxreg_server.Models.Guest> Guest { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}
    }
}
