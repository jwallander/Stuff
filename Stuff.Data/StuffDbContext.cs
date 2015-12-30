using Stuff.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff.Data
{
    public class StuffDbContext : DbContext
    {
        // ToDo: Move Initializer to Global.asax; don't want dependence on SampleData
        static StuffDbContext()
        {
            Database.SetInitializer(new StuffDatabaseInitializer());
        }

        public StuffDbContext()
            : base(nameOrConnectionString: "Stuff")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new SessionConfiguration());
            //modelBuilder.Configurations.Add(new AttendanceConfiguration());
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
