using System.Data.Entity;
using Income.Models;

namespace Income.Repositories
{
    public class IncomeDbContext: DbContext
    {
        public IncomeDbContext(): base("name=IncomeDataConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<IncomeDbContext, Migrations.Configuration>("IncomeDataConnection"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
