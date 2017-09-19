using Income.Models;
using System.Data.Entity.Migrations;

namespace Income.Repositories.Migrations.SeedData
{
    internal static class SkillsSeeder
    {
        public static void Seed(IncomeDbContext dbContext)
        {
            dbContext.Skills.AddOrUpdate(new Skill() {Id = 1, Title = "Drawing" });
            dbContext.Skills.AddOrUpdate(new Skill() {Id = 2, Title = "Programming" });
            dbContext.Skills.AddOrUpdate(new Skill() {Id = 3, Title = "Flat repairing" });
        }
    }
}
