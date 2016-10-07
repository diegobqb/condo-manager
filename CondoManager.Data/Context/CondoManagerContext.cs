using CondoManager.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CondoManager.Data.Context
{
    public class CondoManagerContext : DbContext
    {
        public DbSet<Condo> Condos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
