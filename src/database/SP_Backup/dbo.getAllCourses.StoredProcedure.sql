USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getAllCourses]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getAllCourses] 
as
begin
	select * from Courses
end
GO
