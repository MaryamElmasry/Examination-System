USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[RemoveInstructorFromCourse]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure to remove an instructor from a course
CREATE PROCEDURE [dbo].[RemoveInstructorFromCourse]
    @CourseID INT,
    @InstructorID INT
AS
BEGIN
    -- Delete the entry
    DELETE FROM Instructor_Courses WHERE CourseID = @CourseID AND InstructorID = @InstructorID
END
GO
