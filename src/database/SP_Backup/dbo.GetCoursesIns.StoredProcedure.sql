USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesIns]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetCoursesIns] @insId int
as
begin
select c.CourseID , CourseName from Courses c join Instructor_Courses ic on
ic.CourseID = c.CourseID
where ic.InstructorID = @insId
end
---------------------------------------
GO
