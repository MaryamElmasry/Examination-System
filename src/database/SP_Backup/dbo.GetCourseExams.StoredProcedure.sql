USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCourseExams]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCourseExams]
    @DeptID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate,Exams.Duration
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    WHERE Exams.DeptID = @DeptID;
END;
GO
