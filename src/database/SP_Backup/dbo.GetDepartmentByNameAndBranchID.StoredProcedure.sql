USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetDepartmentByNameAndBranchID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetDepartmentByNameAndBranchID] @name nvarchar(255), @id int
as
begin
	select * from Departments where LOWER(DeptName) = Lower(@name) and BranchID = @id 
end
GO
