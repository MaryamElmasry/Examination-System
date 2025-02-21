USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByInstructorID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCoursesByInstructorID]
    @InstructorID INT
AS
BEGIN
    SELECT Courses.CourseID, Courses.CourseName
    FROM Courses
    INNER JOIN Instructor_Courses ON Courses.CourseID = Instructor_Courses.CourseID
    WHERE Instructor_Courses.InstructorID = @InstructorID
END
GO
