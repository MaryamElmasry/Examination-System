USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseByName]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getCourseByName] @name nvarchar(255)
as
begin
	select * from Courses where CourseName=@name
end
GO
