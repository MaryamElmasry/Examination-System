﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace application.Models;

public partial class iti_ExamContext : DbContext
{
    public iti_ExamContext()
    {
    }

    public iti_ExamContext(DbContextOptions<iti_ExamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseTopic> CourseTopics { get; set; }

    public virtual DbSet<Course_Dept> Course_Depts { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Instructor_Course> Instructor_Courses { get; set; }

    public virtual DbSet<QuestionChoice> QuestionChoices { get; set; }

    public virtual DbSet<QuestionPool> QuestionPools { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentExamQuestion> StudentExamQuestions { get; set; }

    public virtual DbSet<StudentGrade> StudentGrades { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=iti_Exam;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__Branches__A1682FA532DF9A60");

            entity.Property(e => e.BranchName)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseID).HasName("PK__Courses__C92D7187F9416A37");

            entity.HasIndex(e => e.CourseName, "CourseName_Courses").IsUnique();

            entity.Property(e => e.CourseName)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<CourseTopic>(entity =>
        {
            entity.HasKey(e => new { e.Topic, e.CourseID }).HasName("PK__CourseTo__70515EC6F540393D");

            entity.Property(e => e.Topic).HasMaxLength(255);

            entity.HasOne(d => d.Course).WithMany(p => p.CourseTopics)
                .HasForeignKey(d => d.CourseID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CourseTop__Cours__534D60F1");
        });

        modelBuilder.Entity<Course_Dept>(entity =>
        {
            entity.HasKey(e => new { e.CourseID, e.DeptID });

            entity.ToTable("Course_Dept");

            entity.HasOne(d => d.Course).WithMany(p => p.Course_Depts)
                .HasForeignKey(d => d.CourseID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Course_Dept_Courses");

            entity.HasOne(d => d.Dept).WithMany(p => p.Course_Depts)
                .HasForeignKey(d => d.DeptID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Course_Dept_Departments");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptID).HasName("PK__Departme__0148818E3DA310CE");

            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasMaxLength(255);

            entity.HasOne(d => d.Branch).WithMany(p => p.Departments)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__Departmen__Branc__5441852A");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamID).HasName("PK__Exams__297521A77FB4F9FF");

            entity.Property(e => e.ExamDate).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseID)
                .HasConstraintName("FK__Exams__CourseID__571DF1D5");

            entity.HasOne(d => d.Dept).WithMany(p => p.Exams)
                .HasForeignKey(d => d.DeptID)
                .HasConstraintName("FK_Exams_Departments");
        });

        modelBuilder.Entity<ExamQuestion>(entity =>
        {
            entity.HasKey(e => new { e.ExamID, e.QuestionID }).HasName("PK__ExamQues__F9A9275FD4DDEE9C");

            entity.HasOne(d => d.Exam).WithMany(p => p.ExamQuestions)
                .HasForeignKey(d => d.ExamID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ExamQuest__ExamI__5535A963");

            entity.HasOne(d => d.Question).WithMany(p => p.ExamQuestions)
                .HasForeignKey(d => d.QuestionID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ExamQuest__Quest__5629CD9C");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InstructorID).HasName("PK__Instruct__9D010B7BD0D5A330");

            entity.Property(e => e.InstructorID).ValueGeneratedNever();

            entity.HasOne(d => d.Branch).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructors_Branches");

            entity.HasOne(d => d.InstructorNavigation).WithOne(p => p.Instructor)
                .HasForeignKey<Instructor>(d => d.InstructorID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Instructo__Instr__59FA5E80");
        });

        modelBuilder.Entity<Instructor_Course>(entity =>
        {
            entity.HasKey(e => new { e.CourseID, e.InstructorID });

            entity.HasOne(d => d.Course).WithMany(p => p.Instructor_Courses)
                .HasForeignKey(d => d.CourseID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructor_Courses_Courses");

            /*entity.HasOne(d => d.Instructor).WithMany(p => p.Instructor_Courses)
                .HasForeignKey(d => d.InstructorID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructor_Courses_Instructors");*/
        });

        modelBuilder.Entity<QuestionChoice>(entity =>
        {
            entity.HasKey(e => new { e.QuestionID, e.ChoiceIndex }).HasName("PK__Question__6CFB75DBC3C70E25");

            entity.Property(e => e.Choice)
                .IsRequired()
                .HasMaxLength(255);

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionChoices)
                .HasForeignKey(d => d.QuestionID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuestionC__Quest__5AEE82B9");
        });

        modelBuilder.Entity<QuestionPool>(entity =>
        {
            entity.HasKey(e => e.QuestionID).HasName("PK__Question__0DC06F8C1054AE25");

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(255);

            entity.HasOne(d => d.Course).WithMany(p => p.QuestionPools)
                .HasForeignKey(d => d.CourseID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuestionP__Cours__5BE2A6F2");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentID).HasName("PK__Students__32C52A79D18E0E68");

            entity.Property(e => e.StudentID).ValueGeneratedNever();

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptID)
                .HasConstraintName("FK__Students__DeptID__619B8048");

            entity.HasOne(d => d.StudentNavigation).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.StudentID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Students__Studen__628FA481");
        });

        modelBuilder.Entity<StudentExamQuestion>(entity =>
        {
            entity.HasKey(e => new { e.ExamID, e.QuestionID, e.StudentID }).HasName("PK__StudentE__819BE27589F63F79");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.ExamID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__ExamI__5CD6CB2B");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.QuestionID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__Quest__5DCAEF64");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.StudentID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentEx__Stude__5EBF139D");
        });

        modelBuilder.Entity<StudentGrade>(entity =>
        {
            entity.HasKey(e => new { e.CourseID, e.studentID }).HasName("PK__StudentG__1DFC6CE238B34B1F");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentGrades)
                .HasForeignKey(d => d.CourseID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentGr__Cours__5FB337D6");

            entity.HasOne(d => d.student).WithMany(p => p.StudentGrades)
                .HasForeignKey(d => d.studentID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentGr__stude__60A75C0F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserID).HasName("PK__Users__1788CCAC31664583");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255);
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(255);
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}