USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetDeptsforIns]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetDeptsforIns] @insId int
as
begin
	select d.DeptName , d.DeptID,d.BranchID from Departments d join Branches b
	on d.BranchID = b.BranchID join Instructors I 
	on I.BranchID = b.BranchID
	where i.InstructorID = @insId
end
---------------------------------------
GO
