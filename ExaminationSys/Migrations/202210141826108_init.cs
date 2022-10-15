namespace ExaminationSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Allowances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(nullable: false),
                        Calculator = c.Boolean(nullable: false),
                        OpenBook = c.Boolean(nullable: false),
                        UseInternet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true)
                .Index(t => t.ExamId);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsCorrective = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
            CreateTable(
                "dbo.BranchDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptId = c.Int(nullable: false),
                        IntakeId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        TrackId = c.Int(nullable: false),
                        CrsId = c.Int(nullable: false),
                        StdId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CrsId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DeptId, cascadeDelete: true)
                .ForeignKey("dbo.Intakes", t => t.IntakeId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StdId, cascadeDelete: true)
                .ForeignKey("dbo.Tracks", t => t.TrackId, cascadeDelete: true)
                .Index(t => t.DeptId)
                .Index(t => t.IntakeId)
                .Index(t => t.BranchId)
                .Index(t => t.TrackId)
                .Index(t => t.CrsId)
                .Index(t => t.StdId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BranchId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CrsId = c.Int(nullable: false, identity: true),
                        CrsTitle = c.String(nullable: false, maxLength: 50),
                        CrsDesc = c.String(maxLength: 200),
                        CrsMinDegree = c.Int(nullable: false),
                        CrsMaxDegree = c.Int(nullable: false),
                        InsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CrsId)
                .ForeignKey("dbo.Instructors", t => t.InsId, cascadeDelete: true)
                .Index(t => t.InsId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InsId = c.Int(nullable: false, identity: true),
                        InsName = c.String(nullable: false, maxLength: 50),
                        InsUserName = c.String(nullable: false, maxLength: 50),
                        InsPassword = c.String(nullable: false),
                        SuperID = c.Int(nullable: false),
                        User_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.InsId)
                .ForeignKey("dbo.Instructors", t => t.SuperID)
                .ForeignKey("dbo.Users", t => t.User_ClassId)
                .Index(t => t.SuperID)
                .Index(t => t.User_ClassId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Intakes",
                c => new
                    {
                        IntakeId = c.Int(nullable: false, identity: true),
                        IntakeNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IntakeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StdId = c.Int(nullable: false, identity: true),
                        StdName = c.String(nullable: false, maxLength: 50),
                        StdEmail = c.String(nullable: false, maxLength: 50),
                        StdUserName = c.String(nullable: false, maxLength: 50),
                        StdPassword = c.String(nullable: false, maxLength: 50),
                        User_ClassId = c.Int(),
                    })
                .PrimaryKey(t => t.StdId)
                .ForeignKey("dbo.Users", t => t.User_ClassId)
                .Index(t => t.User_ClassId);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        TrackId = c.Int(nullable: false, identity: true),
                        TrackName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TrackId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassNumber = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.CrsInsPerYears",
                c => new
                    {
                        ClassId = c.Int(nullable: false),
                        CrsId = c.Int(nullable: false),
                        InsId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => new { t.ClassId, t.CrsId, t.InsId, t.Year })
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CrsId, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.InsId)
                .Index(t => t.ClassId)
                .Index(t => t.CrsId)
                .Index(t => t.InsId);
            
            CreateTable(
                "dbo.ExamQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QstDegree = c.Int(nullable: false),
                        QstType = c.String(nullable: false, maxLength: 3),
                        ExamId = c.Int(nullable: false),
                        MCQId = c.Int(nullable: false),
                        TFQId = c.Int(nullable: false),
                        TXQId = c.Int(nullable: false),
                        CrsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CrsId, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true)
                .ForeignKey("dbo.MCQuestions", t => t.MCQId, cascadeDelete: true)
                .ForeignKey("dbo.TFQuestions", t => t.TFQId, cascadeDelete: true)
                .ForeignKey("dbo.TxtQuestions", t => t.TXQId, cascadeDelete: true)
                .Index(t => t.ExamId)
                .Index(t => t.MCQId)
                .Index(t => t.TFQId)
                .Index(t => t.TXQId)
                .Index(t => t.CrsId);
            
            CreateTable(
                "dbo.MCQuestions",
                c => new
                    {
                        McqId = c.Int(nullable: false, identity: true),
                        McqContent = c.String(nullable: false, maxLength: 200),
                        Choice1 = c.String(nullable: false, maxLength: 150),
                        Choice2 = c.String(nullable: false, maxLength: 150),
                        Choice3 = c.String(nullable: false, maxLength: 150),
                        McqFullDegree = c.Int(nullable: false),
                        CrsId = c.Int(),
                    })
                .PrimaryKey(t => t.McqId)
                .ForeignKey("dbo.Courses", t => t.CrsId)
                .Index(t => t.CrsId);
            
            CreateTable(
                "dbo.TFQuestions",
                c => new
                    {
                        TfqId = c.Int(nullable: false, identity: true),
                        TfqContent = c.String(nullable: false, maxLength: 200),
                        TfqCorrectAnswer = c.String(nullable: false, maxLength: 5),
                        TfqFullDegree = c.Int(nullable: false),
                        CrsId = c.Int(),
                    })
                .PrimaryKey(t => t.TfqId)
                .ForeignKey("dbo.Courses", t => t.CrsId)
                .Index(t => t.CrsId);
            
            CreateTable(
                "dbo.TxtQuestions",
                c => new
                    {
                        TxtId = c.Int(nullable: false, identity: true),
                        TxtContent = c.String(nullable: false, maxLength: 200),
                        TxtBestAnswer = c.String(nullable: false, maxLength: 200),
                        TxtFullDegree = c.Int(nullable: false),
                        CrsId = c.Int(),
                    })
                .PrimaryKey(t => t.TxtId)
                .ForeignKey("dbo.Courses", t => t.CrsId)
                .Index(t => t.CrsId);
            
            CreateTable(
                "dbo.StdAnswers",
                c => new
                    {
                        StdId = c.Int(nullable: false),
                        QstId = c.Int(nullable: false, identity: true),
                        QstType = c.String(nullable: false, maxLength: 3),
                        StdAnswer = c.String(maxLength: 200),
                        ExamId = c.Int(nullable: false),
                        StdDegree = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.StdId, t.QstId, t.QstType })
                .ForeignKey("dbo.Students", t => t.StdId, cascadeDelete: true)
                .Index(t => t.StdId);
            
            CreateTable(
                "dbo.StudentExams",
                c => new
                    {
                        StdId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        Result = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StdId, t.ExamId })
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StdId, cascadeDelete: true)
                .Index(t => t.StdId)
                .Index(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentExams", "StdId", "dbo.Students");
            DropForeignKey("dbo.StudentExams", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.StdAnswers", "StdId", "dbo.Students");
            DropForeignKey("dbo.ExamQuestions", "TXQId", "dbo.TxtQuestions");
            DropForeignKey("dbo.TxtQuestions", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.ExamQuestions", "TFQId", "dbo.TFQuestions");
            DropForeignKey("dbo.TFQuestions", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.ExamQuestions", "MCQId", "dbo.MCQuestions");
            DropForeignKey("dbo.MCQuestions", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.ExamQuestions", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.ExamQuestions", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.CrsInsPerYears", "InsId", "dbo.Instructors");
            DropForeignKey("dbo.CrsInsPerYears", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.CrsInsPerYears", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.BranchDetails", "TrackId", "dbo.Tracks");
            DropForeignKey("dbo.BranchDetails", "StdId", "dbo.Students");
            DropForeignKey("dbo.Students", "User_ClassId", "dbo.Users");
            DropForeignKey("dbo.BranchDetails", "IntakeId", "dbo.Intakes");
            DropForeignKey("dbo.BranchDetails", "DeptId", "dbo.Departments");
            DropForeignKey("dbo.BranchDetails", "CrsId", "dbo.Courses");
            DropForeignKey("dbo.Instructors", "User_ClassId", "dbo.Users");
            DropForeignKey("dbo.Instructors", "SuperID", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "InsId", "dbo.Instructors");
            DropForeignKey("dbo.BranchDetails", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.Allowances", "ExamId", "dbo.Exams");
            DropIndex("dbo.StudentExams", new[] { "ExamId" });
            DropIndex("dbo.StudentExams", new[] { "StdId" });
            DropIndex("dbo.StdAnswers", new[] { "StdId" });
            DropIndex("dbo.TxtQuestions", new[] { "CrsId" });
            DropIndex("dbo.TFQuestions", new[] { "CrsId" });
            DropIndex("dbo.MCQuestions", new[] { "CrsId" });
            DropIndex("dbo.ExamQuestions", new[] { "CrsId" });
            DropIndex("dbo.ExamQuestions", new[] { "TXQId" });
            DropIndex("dbo.ExamQuestions", new[] { "TFQId" });
            DropIndex("dbo.ExamQuestions", new[] { "MCQId" });
            DropIndex("dbo.ExamQuestions", new[] { "ExamId" });
            DropIndex("dbo.CrsInsPerYears", new[] { "InsId" });
            DropIndex("dbo.CrsInsPerYears", new[] { "CrsId" });
            DropIndex("dbo.CrsInsPerYears", new[] { "ClassId" });
            DropIndex("dbo.Students", new[] { "User_ClassId" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.Instructors", new[] { "User_ClassId" });
            DropIndex("dbo.Instructors", new[] { "SuperID" });
            DropIndex("dbo.Courses", new[] { "InsId" });
            DropIndex("dbo.BranchDetails", new[] { "StdId" });
            DropIndex("dbo.BranchDetails", new[] { "CrsId" });
            DropIndex("dbo.BranchDetails", new[] { "TrackId" });
            DropIndex("dbo.BranchDetails", new[] { "BranchId" });
            DropIndex("dbo.BranchDetails", new[] { "IntakeId" });
            DropIndex("dbo.BranchDetails", new[] { "DeptId" });
            DropIndex("dbo.Allowances", new[] { "ExamId" });
            DropTable("dbo.StudentExams");
            DropTable("dbo.StdAnswers");
            DropTable("dbo.TxtQuestions");
            DropTable("dbo.TFQuestions");
            DropTable("dbo.MCQuestions");
            DropTable("dbo.ExamQuestions");
            DropTable("dbo.CrsInsPerYears");
            DropTable("dbo.Classes");
            DropTable("dbo.Tracks");
            DropTable("dbo.Students");
            DropTable("dbo.Intakes");
            DropTable("dbo.Departments");
            DropTable("dbo.Users");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
            DropTable("dbo.Branches");
            DropTable("dbo.BranchDetails");
            DropTable("dbo.Exams");
            DropTable("dbo.Allowances");
        }
    }
}
