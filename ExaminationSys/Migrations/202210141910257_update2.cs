namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamQuestions", "MCQId", "dbo.MCQuestions");
            DropForeignKey("dbo.ExamQuestions", "TFXQId", "dbo.TFQuestions");
            DropForeignKey("dbo.ExamQuestions", "TXQId", "dbo.TxtQuestions");
            DropIndex("dbo.ExamQuestions", new[] { "MCQId" });
            DropIndex("dbo.ExamQuestions", new[] { "TFXQId" });
            DropIndex("dbo.ExamQuestions", new[] { "TXQId" });
            AlterColumn("dbo.ExamQuestions", "MCQId", c => c.Int());
            AlterColumn("dbo.ExamQuestions", "TFXQId", c => c.Int());
            AlterColumn("dbo.ExamQuestions", "TXQId", c => c.Int());
            CreateIndex("dbo.ExamQuestions", "MCQId");
            CreateIndex("dbo.ExamQuestions", "TFXQId");
            CreateIndex("dbo.ExamQuestions", "TXQId");
            AddForeignKey("dbo.ExamQuestions", "MCQId", "dbo.MCQuestions", "McqId");
            AddForeignKey("dbo.ExamQuestions", "TFXQId", "dbo.TFQuestions", "TfqId");
            AddForeignKey("dbo.ExamQuestions", "TXQId", "dbo.TxtQuestions", "TxtId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamQuestions", "TXQId", "dbo.TxtQuestions");
            DropForeignKey("dbo.ExamQuestions", "TFXQId", "dbo.TFQuestions");
            DropForeignKey("dbo.ExamQuestions", "MCQId", "dbo.MCQuestions");
            DropIndex("dbo.ExamQuestions", new[] { "TXQId" });
            DropIndex("dbo.ExamQuestions", new[] { "TFXQId" });
            DropIndex("dbo.ExamQuestions", new[] { "MCQId" });
            AlterColumn("dbo.ExamQuestions", "TXQId", c => c.Int(nullable: false));
            AlterColumn("dbo.ExamQuestions", "TFXQId", c => c.Int(nullable: false));
            AlterColumn("dbo.ExamQuestions", "MCQId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExamQuestions", "TXQId");
            CreateIndex("dbo.ExamQuestions", "TFXQId");
            CreateIndex("dbo.ExamQuestions", "MCQId");
            AddForeignKey("dbo.ExamQuestions", "TXQId", "dbo.TxtQuestions", "TxtId", cascadeDelete: true);
            AddForeignKey("dbo.ExamQuestions", "TFXQId", "dbo.TFQuestions", "TfqId", cascadeDelete: true);
            AddForeignKey("dbo.ExamQuestions", "MCQId", "dbo.MCQuestions", "McqId", cascadeDelete: true);
        }
    }
}
