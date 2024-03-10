using System;
using System.Linq;
using application.Models;

namespace application.Utilites
{
    public class InitializeDB
    {
        public void AddDummyUserData(iti_ExamContext context)
        {
            if (context.Users.Any() && context.Students.Any() && context.Instructors.Any())
            {
                Console.WriteLine("Database already contains Users data. Dummy data not added.");
                return;
            }
            //Delete the database
            //context.Database.EnsureDeleted();
            //Create the database
            //context.Database.EnsureCreated();

            // Add dummy data for Departments
            var department1 = new Department { DeptName = "PD" };

            context.Departments.AddRange(department1);
            context.SaveChanges();

            // Add dummy data for Users (assuming your Users table is the base class)
            var user1 = new User
            {
                UserName = "Ahmed",
                Email = "Ahmed@gmail.com",
                Address = "123 Main St",
                Password = "123",
                Phone = "123-456-7890",
                Gender = "M"
            };

            var user2 = new User
            {
                UserName = "maryam",
                Email = "maryam@gmail.com",
                Address = "456 Oak St",
                Password = "123",
                Phone = "987-654-3210",
                Gender = "F"
            };

            context.Users.AddRange(user1, user2);
            context.SaveChanges();

            // Add dummy data for Students
            var student1 = new Student
            {
                DeptID = department1.DeptID,
                StudentNavigation = user1
            };

            var student2 = new Student
            {
                DeptID = department1.DeptID,
                StudentNavigation = user2
            };

            context.Students.AddRange(student1, student2);
            context.SaveChanges();

            // Add dummy data for Instructors
            var instructor1 = new Instructor
            {
                DeptID = department1.DeptID,
                InstructorNavigation = new User
                {
                    UserName = "Abdo",
                    Email = "abdo@gmail.com",
                    Address = "789 Elm St",
                    Password = "123",
                    Phone = "111-222-3333",
                    Gender = "M"
                }
            };

            var instructor2 = new Instructor
            {
                DeptID = department1.DeptID,
                InstructorNavigation = new User
                {
                    UserName = "saberr",
                    Email = "saberr@gmail.com",
                    Address = "987 Pine St",
                    Password = "123",
                    Phone = "444-555-6666",
                    Gender = "M"
                }
            };

            context.Instructors.AddRange(instructor1, instructor2);
            context.SaveChanges();

            Console.WriteLine("Dummy data added successfully.");
        }
    }
}
