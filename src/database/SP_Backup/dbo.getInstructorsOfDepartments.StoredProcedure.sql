USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getInstructorsOfDepartments]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getInstructorsOfDepartments] @deptID int
as
begin
	select u.*
	from Branches b inner join Departments d
	on b.BranchID = d.BranchID
	inner join Instructors i
	on i.BranchID = b.BranchID
	inner join Users u
	on u.UserID=i.InstructorID
	where d.DeptID = @deptID
end
GO
