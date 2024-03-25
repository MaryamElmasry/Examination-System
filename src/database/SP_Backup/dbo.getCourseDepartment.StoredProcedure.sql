USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartment]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartment] @courseID int, @deptID int
as
begin
	select * from Course_Dept where DeptId = @deptID and CourseID=@courseID
end
GO
