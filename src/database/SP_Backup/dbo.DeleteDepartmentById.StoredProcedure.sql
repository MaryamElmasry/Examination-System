USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDepartmentById]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[DeleteDepartmentById] @id int
as
begin
	delete from Departments where DeptID=@id
end
GO
