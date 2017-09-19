namespace Income.Repositories.Migrations
{
    using SeedData;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<IncomeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IncomeDbContext context)
        {
            SkillsSeeder.Seed(context);
        }
    }
}
