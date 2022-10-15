namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "User_ClassId", c => c.Int());
            AddColumn("dbo.Students", "User_ClassId", c => c.Int());
            CreateIndex("dbo.Instructors", "User_ClassId");
            CreateIndex("dbo.Students", "User_ClassId");
            AddForeignKey("dbo.Instructors", "User_ClassId", "dbo.Users", "ClassId");
            AddForeignKey("dbo.Students", "User_ClassId", "dbo.Users", "ClassId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "User_ClassId", "dbo.Users");
            DropForeignKey("dbo.Instructors", "User_ClassId", "dbo.Users");
            DropIndex("dbo.Students", new[] { "User_ClassId" });
            DropIndex("dbo.Instructors", new[] { "User_ClassId" });
            DropColumn("dbo.Students", "User_ClassId");
            DropColumn("dbo.Instructors", "User_ClassId");
        }
    }
}
