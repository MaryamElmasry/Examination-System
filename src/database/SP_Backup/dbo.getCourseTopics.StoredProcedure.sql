USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseTopics]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseTopics] @id int
as
begin
	select * from CourseTopics where CourseID=@id;
end
GO
