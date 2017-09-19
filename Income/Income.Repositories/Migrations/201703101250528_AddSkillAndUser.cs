namespace Income.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSkillAndUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(maxLength: 30),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(),
                        Phone = c.String(nullable: false, maxLength: 30),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Skill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Skill_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Skill_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSkills", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.UserSkills", "User_Id", "dbo.Users");
            DropIndex("dbo.UserSkills", new[] { "Skill_Id" });
            DropIndex("dbo.UserSkills", new[] { "User_Id" });
            DropTable("dbo.UserSkills");
            DropTable("dbo.Users");
            DropTable("dbo.Skills");
        }
    }
}
