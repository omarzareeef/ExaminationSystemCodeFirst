namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamQuestions", "TxtId", "dbo.TxtQuestions");
            DropIndex("dbo.ExamQuestions", new[] { "McqId" });
            DropPrimaryKey("dbo.TxtQuestions");
            DropColumn("dbo.TxtQuestions", "TxtId");
            RenameColumn(table: "dbo.ExamQuestions", name: "TxtId", newName: "TxtQId");
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_TxtId", newName: "IX_TxtQId");
            AddColumn("dbo.TxtQuestions", "TxtQId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TxtQuestions", "TxtQId");
            CreateIndex("dbo.ExamQuestions", "MCQId");
            AddForeignKey("dbo.ExamQuestions", "TxtQId", "dbo.TxtQuestions", "TxtQId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.TxtQuestions", "TxtId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ExamQuestions", "TxtQId", "dbo.TxtQuestions");
            DropIndex("dbo.ExamQuestions", new[] { "MCQId" });
            DropPrimaryKey("dbo.TxtQuestions");
            DropColumn("dbo.TxtQuestions", "TxtQId");
            AddPrimaryKey("dbo.TxtQuestions", "TxtId");
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_TxtQId", newName: "IX_TxtId");
            RenameColumn(table: "dbo.ExamQuestions", name: "TxtQId", newName: "TxtId");
            CreateIndex("dbo.ExamQuestions", "McqId");
            AddForeignKey("dbo.ExamQuestions", "TxtId", "dbo.TxtQuestions", "TxtId", cascadeDelete: true);
        }
    }
}
