USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[addInstructorCourse]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[addInstructorCourse] @crsid int, @instructorID int
as
begin
	insert into Instructor_Courses values(@crsid, @instructorID)
end
GO
