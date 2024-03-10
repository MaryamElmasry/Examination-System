﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using application.Models;

#nullable disable

namespace application.Migrations
{
    [DbContext(typeof(iti_ExamContext))]
    partial class iti_ExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("ExamID", "QuestionID")
                        .HasName("PK__ExamQues__F9A9275FD4DDEE9C");

                    b.HasIndex("QuestionID");

                    b.ToTable("ExamQuestions", (string)null);
                });

            modelBuilder.Entity("application.Models.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchID"));

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("BranchID")
                        .HasName("PK__Branches__A1682FA532DF9A60");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("application.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.HasKey("CourseID")
                        .HasName("PK__Courses__C92D7187F9416A37");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("application.Models.CourseTopic", b =>
                {
                    b.Property<string>("Topic")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.HasKey("Topic", "CourseID")
                        .HasName("PK__CourseTo__70515EC6F540393D");

                    b.HasIndex("CourseID");

                    b.ToTable("CourseTopics");
                });

            modelBuilder.Entity("application.Models.Department", b =>
                {
                    b.Property<int>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptID"));

                    b.Property<int?>("BranchID")
                        .HasColumnType("int");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("DeptID")
                        .HasName("PK__Departme__0148818E3DA310CE");

                    b.HasIndex("BranchID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("application.Models.Exam", b =>
                {
                    b.Property<int>("ExamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamID"));

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("DeptID")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime");

                    b.HasKey("ExamID")
                        .HasName("PK__Exams__297521A77FB4F9FF");

                    b.HasIndex("CourseID");

                    b.HasIndex("DeptID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("application.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DeptID")
                        .HasColumnType("int");

                    b.HasKey("InstructorID")
                        .HasName("PK__Instruct__9D010B7BD0D5A330");

                    b.HasIndex("DeptID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("application.Models.QuestionChoice", b =>
                {
                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("ChoiceIndex")
                        .HasColumnType("int");

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("QuestionID", "ChoiceIndex")
                        .HasName("PK__Question__6CFB75DBC3C70E25");

                    b.ToTable("QuestionChoices");
                });

            modelBuilder.Entity("application.Models.QuestionPool", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionID"));

                    b.Property<int>("CorrectAnswerIndex")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("QuestionID")
                        .HasName("PK__Question__0DC06F8C1054AE25");

                    b.HasIndex("CourseID");

                    b.ToTable("QuestionPools");
                });

            modelBuilder.Entity("application.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("DeptID")
                        .HasColumnType("int");

                    b.HasKey("StudentID")
                        .HasName("PK__Students__32C52A79D18E0E68");

                    b.HasIndex("DeptID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("application.Models.StudentExamQuestion", b =>
                {
                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SelectedAnswerIndex")
                        .HasColumnType("int");

                    b.HasKey("ExamID", "QuestionID", "StudentID")
                        .HasName("PK__StudentE__819BE27589F63F79");

                    b.HasIndex("QuestionID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentExamQuestions");
                });

            modelBuilder.Entity("application.Models.StudentGrade", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("studentID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "studentID")
                        .HasName("PK__StudentG__1DFC6CE238B34B1F");

                    b.HasIndex("studentID");

                    b.ToTable("StudentGrades");
                });

            modelBuilder.Entity("application.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserID")
                        .HasName("PK__Users__1788CCAC31664583");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExamQuestion", b =>
                {
                    b.HasOne("application.Models.Exam", null)
                        .WithMany()
                        .HasForeignKey("ExamID")
                        .IsRequired()
                        .HasConstraintName("FK__ExamQuest__ExamI__5535A963");

                    b.HasOne("application.Models.QuestionPool", null)
                        .WithMany()
                        .HasForeignKey("QuestionID")
                        .IsRequired()
                        .HasConstraintName("FK__ExamQuest__Quest__5629CD9C");
                });

            modelBuilder.Entity("application.Models.Course", b =>
                {
                    b.HasOne("application.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorID")
                        .IsRequired()
                        .HasConstraintName("FK__Courses__Instruc__52593CB8");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("application.Models.CourseTopic", b =>
                {
                    b.HasOne("application.Models.Course", "Course")
                        .WithMany("CourseTopics")
                        .HasForeignKey("CourseID")
                        .IsRequired()
                        .HasConstraintName("FK__CourseTop__Cours__534D60F1");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("application.Models.Department", b =>
                {
                    b.HasOne("application.Models.Branch", "Branch")
                        .WithMany("Departments")
                        .HasForeignKey("BranchID")
                        .HasConstraintName("FK__Departmen__Branc__5441852A");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("application.Models.Exam", b =>
                {
                    b.HasOne("application.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseID")
                        .HasConstraintName("FK__Exams__CourseID__571DF1D5");

                    b.HasOne("application.Models.Department", "Dept")
                        .WithMany("Exams")
                        .HasForeignKey("DeptID")
                        .HasConstraintName("FK_Exams_Departments");

                    b.Navigation("Course");

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("application.Models.Instructor", b =>
                {
                    b.HasOne("application.Models.Department", "Dept")
                        .WithMany("Instructors")
                        .HasForeignKey("DeptID")
                        .HasConstraintName("FK__Instructo__DeptI__59063A47");

                    b.HasOne("application.Models.User", "InstructorNavigation")
                        .WithOne("Instructor")
                        .HasForeignKey("application.Models.Instructor", "InstructorID")
                        .IsRequired()
                        .HasConstraintName("FK__Instructo__Instr__59FA5E80");

                    b.Navigation("Dept");

                    b.Navigation("InstructorNavigation");
                });

            modelBuilder.Entity("application.Models.QuestionChoice", b =>
                {
                    b.HasOne("application.Models.QuestionPool", "Question")
                        .WithMany("QuestionChoices")
                        .HasForeignKey("QuestionID")
                        .IsRequired()
                        .HasConstraintName("FK__QuestionC__Quest__5AEE82B9");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("application.Models.QuestionPool", b =>
                {
                    b.HasOne("application.Models.Course", "Course")
                        .WithMany("QuestionPools")
                        .HasForeignKey("CourseID")
                        .IsRequired()
                        .HasConstraintName("FK__QuestionP__Cours__5BE2A6F2");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("application.Models.Student", b =>
                {
                    b.HasOne("application.Models.Department", "Dept")
                        .WithMany("Students")
                        .HasForeignKey("DeptID")
                        .HasConstraintName("FK__Students__DeptID__619B8048");

                    b.HasOne("application.Models.User", "StudentNavigation")
                        .WithOne("Student")
                        .HasForeignKey("application.Models.Student", "StudentID")
                        .IsRequired()
                        .HasConstraintName("FK__Students__Studen__628FA481");

                    b.Navigation("Dept");

                    b.Navigation("StudentNavigation");
                });

            modelBuilder.Entity("application.Models.StudentExamQuestion", b =>
                {
                    b.HasOne("application.Models.Exam", "Exam")
                        .WithMany("StudentExamQuestions")
                        .HasForeignKey("ExamID")
                        .IsRequired()
                        .HasConstraintName("FK__StudentEx__ExamI__5CD6CB2B");

                    b.HasOne("application.Models.QuestionPool", "Question")
                        .WithMany("StudentExamQuestions")
                        .HasForeignKey("QuestionID")
                        .IsRequired()
                        .HasConstraintName("FK__StudentEx__Quest__5DCAEF64");

                    b.HasOne("application.Models.Student", "Student")
                        .WithMany("StudentExamQuestions")
                        .HasForeignKey("StudentID")
                        .IsRequired()
                        .HasConstraintName("FK__StudentEx__Stude__5EBF139D");

                    b.Navigation("Exam");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("application.Models.StudentGrade", b =>
                {
                    b.HasOne("application.Models.Course", "Course")
                        .WithMany("StudentGrades")
                        .HasForeignKey("CourseID")
                        .IsRequired()
                        .HasConstraintName("FK__StudentGr__Cours__5FB337D6");

                    b.HasOne("application.Models.Student", "student")
                        .WithMany("StudentGrades")
                        .HasForeignKey("studentID")
                        .IsRequired()
                        .HasConstraintName("FK__StudentGr__stude__60A75C0F");

                    b.Navigation("Course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("application.Models.Branch", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("application.Models.Course", b =>
                {
                    b.Navigation("CourseTopics");

                    b.Navigation("Exams");

                    b.Navigation("QuestionPools");

                    b.Navigation("StudentGrades");
                });

            modelBuilder.Entity("application.Models.Department", b =>
                {
                    b.Navigation("Exams");

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("application.Models.Exam", b =>
                {
                    b.Navigation("StudentExamQuestions");
                });

            modelBuilder.Entity("application.Models.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("application.Models.QuestionPool", b =>
                {
                    b.Navigation("QuestionChoices");

                    b.Navigation("StudentExamQuestions");
                });

            modelBuilder.Entity("application.Models.Student", b =>
                {
                    b.Navigation("StudentExamQuestions");

                    b.Navigation("StudentGrades");
                });

            modelBuilder.Entity("application.Models.User", b =>
                {
                    b.Navigation("Instructor");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
