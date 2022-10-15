﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys
{
    internal class Context : DbContext
    {
        public Context () 
            : base(@"data source =.; initial catalog = ExaminationSystemCF; integrated security = True") { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StdAnswers> StdAnswers { get; set; }
        public virtual DbSet<StudentExam> StudentExams { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<MCQuestion> MCQuestions { get; set; }
        public virtual DbSet<TFQuestion> TFQuestions { get; set; }
        public virtual DbSet<TxtQuestion> TxtQuestions { get; set; }
        public virtual DbSet<CrsInsPerYear> CrsInsPerYears { get; set; }
        public virtual DbSet<BranchDetails> BranchDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrsInsPerYear>()
                .HasRequired<Instructor>(s => s.Instructor)
                .WithMany()
                .WillCascadeOnDelete(false);
            //modelBuilder.Entity<MCQuestion>()
            //    .HasOptional<Course>(s => s.Course)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<TFQuestion>()
            //    .HasOptional<Course>(s => s.Course)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<TxtQuestion>()
            //    .HasOptional<Course>(s => s.Course)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }
    }
}
