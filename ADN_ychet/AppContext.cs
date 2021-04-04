using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ADN_ychet
{
    class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection") { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Equipment> Equipment { get; set; }


    }
}
