USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCourseInfo]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCourseInfo]
    @CourseID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CourseName, ExamDate
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    WHERE Courses.CourseID = @CourseID;
END
GO
