USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetExamGradesByStudentID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetExamGradesByStudentID]
    @StudentID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate, StudentGrades.Grade
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    INNER JOIN StudentGrades ON Courses.CourseID = StudentGrades.CourseID
    WHERE StudentGrades.StudentID = @StudentID
END;
GO
