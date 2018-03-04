using System.Data.Entity;
using webapp3.Data.Entities;

namespace webapp3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
    }

    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        // intentionally left blank
    }

}