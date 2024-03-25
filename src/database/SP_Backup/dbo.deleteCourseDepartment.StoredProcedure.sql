USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseDepartment]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[deleteCourseDepartment] @courseID int, @deptID int
as
begin
	delete from Course_Dept where CourseID=@courseID and DeptId=@deptID
end
GO
