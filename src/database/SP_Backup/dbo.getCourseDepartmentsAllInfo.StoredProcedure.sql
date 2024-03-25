USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartmentsAllInfo]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartmentsAllInfo] @courseId int
as
begin
	select d.* 
	from Course_Dept cp inner join Departments d
	on cp.DeptId = d.DeptID
	where CourseID=@courseId;
end
GO
