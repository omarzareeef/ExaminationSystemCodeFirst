namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ExamQuestions", name: "TFQId", newName: "TFXQId");
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_TFQId", newName: "IX_TFXQId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_TFXQId", newName: "IX_TFQId");
            RenameColumn(table: "dbo.ExamQuestions", name: "TFXQId", newName: "TFQId");
        }
    }
}
