USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructorsInfo]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getCourseInstructorsInfo] @courseId nvarchar(255)
as
begin
	select i.*
	from Instructor_Courses ic inner join Users i
	on ic.InstructorID = i.UserID
	where ic.CourseID = @courseId
end
GO
