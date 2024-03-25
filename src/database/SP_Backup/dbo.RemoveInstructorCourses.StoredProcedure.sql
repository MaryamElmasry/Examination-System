USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[RemoveInstructorCourses]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveInstructorCourses]
    @InstructorID INT
AS
BEGIN
    -- Delete the entry
    DELETE FROM Instructor_Courses WHERE  InstructorID = @InstructorID
END
GO
