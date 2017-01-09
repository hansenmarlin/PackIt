using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PackIt.Models
{
    public class PackItDB : DbContext
    {
        public PackItDB() : base("DefaultConnection")
        {

        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<PackingList> PackingLists { get; set; }
        public DbSet<Season> Seasons { get; set; }

    }
}