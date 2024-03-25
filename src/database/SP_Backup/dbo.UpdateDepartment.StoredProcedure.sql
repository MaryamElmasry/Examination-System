USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[UpdateDepartment]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[UpdateDepartment] @deptId int, @deptName nvarchar(255), @BranchID int
as
begin
	update Departments set DeptName = @deptName, BranchID=@BranchID
	where DeptID = @deptId
end
GO
