USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartments]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartments] @id int
as
begin
	select * from Course_Dept where CourseID=@id;
end
GO
