USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseInstructorByInstructorIDAndCourseID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[deleteCourseInstructorByInstructorIDAndCourseID] @crsid int, @instructorID int
as
begin
	delete from Instructor_Courses
	where CourseID = @crsid and InstructorID=@instructorID
end
GO
