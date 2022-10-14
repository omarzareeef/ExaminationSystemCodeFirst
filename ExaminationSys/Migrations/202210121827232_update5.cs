namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Allowances", "ExamId", "dbo.Exams");
            DropPrimaryKey("dbo.Allowances");
            AddColumn("dbo.Allowances", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Allowances", "Id");
            AddForeignKey("dbo.Allowances", "ExamId", "dbo.Exams", "ExamId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Allowances", "ExamId", "dbo.Exams");
            DropPrimaryKey("dbo.Allowances");
            DropColumn("dbo.Allowances", "Id");
            AddPrimaryKey("dbo.Allowances", "ExamId");
            AddForeignKey("dbo.Allowances", "ExamId", "dbo.Exams", "ExamId");
        }
    }
}
