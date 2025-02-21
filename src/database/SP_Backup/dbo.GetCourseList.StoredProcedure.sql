USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCourseList]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[GetCourseList] @InsId INT
AS
BEGIN
    SELECT c.CourseName, c.CourseID
    FROM
        Courses	C
		inner join Instructor_Courses IC
		on c.CourseID = ic.CourseID
    WHERE
        Ic.InstructorID = @InsId
END
GO
