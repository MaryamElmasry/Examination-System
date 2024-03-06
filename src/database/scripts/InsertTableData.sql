
-- Insert data into Branches table
INSERT INTO Branches (BranchID, BranchName) VALUES
(1, 'Mansoura'); 

-- Insert data into Departments table
INSERT INTO Departments (DeptID, DeptName, BranchID) VALUES
(1, 'Professional Development', 1); 

-- Insert data into Users table
INSERT INTO Users (UserID, UserName, Email, Address, Password, Phone, Gender) VALUES
(1, 'Ramy', 'ramy@example.com', '123 Main St', 'password1', '1234567890', 'M'),
(2, 'Ahmed Abdallah', 'ahmed@example.com', '456 Oak St', 'password2', '9876543210', 'M');

-- Insert data into Students table
INSERT INTO Students (DeptID, StudentID) VALUES
(1, 2);

-- Insert data into Instructors table
INSERT INTO Instructors (DeptID, InstructorID) VALUES
(1, 1);

-- Insert data into Courses table
INSERT INTO Courses (CourseID, CourseName, DeptID, InstructorID) VALUES
(1001, 'C# Programming', 1, 1);

-- Insert data into Exams table
INSERT INTO Exams (ExamID, ExamDate, Duration, CourseID) VALUES
(5001, '2024-03-07 10:00:00', 120, 1001);

-- Insert data into QuestionPools table
INSERT INTO QuestionPools (QuestionID, Title, QuestionType, CorrectAnswerIndex, Grade, CourseID) VALUES
(6001, 'What is C#?', 1, 1, 10, 1001),
(6002, 'Explain the use of classes in C#', 2, 2, 15, 1001),
(6003, 'What is a variable?', 1, 3, 8, 1001);

-- Insert data into StudentExamQuestions table
INSERT INTO StudentExamQuestions (SelectedAnswerIndex, ExamID, QuestionID, StudentID) VALUES
(1, 5001, 6001, 2),
(2, 5001, 6002, 2),
(3, 5001, 6003, 2);

-- Insert data into ExamQuestions table
INSERT INTO ExamQuestions (ExamID, QuestionID) VALUES
(5001, 6001),
(5001, 6002),
(5001, 6003);

-- Insert data into CourseTopics table
INSERT INTO CourseTopics (Topic, CourseID) VALUES
('Introduction to C#', 1001),
('Classes and Objects', 1001),
('Variables and Data Types', 1001);

-- Insert data into QuestionChoices table
INSERT INTO QuestionChoices (Choice, QuestionID) VALUES
('A programming language', 6001),
('A type of coffee', 6001),
('A musical note', 6001),
('Classes allow you to model real-world entities', 6002),
('Classes are used for mathematical operations', 6002),
('Classes are not useful in programming', 6002),
('A container for storing data', 6003),
('A type of loop', 6003),
('A way to print text', 6003);
