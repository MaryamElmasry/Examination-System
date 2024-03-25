USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[changeCourseName]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[changeCourseName] @id int, @name nvarchar(255) 
as
begin
	update Courses set CourseName=@name where CourseID=@id
end
GO
