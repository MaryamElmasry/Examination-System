USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetAllDepartments]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetAllDepartments]
as
begin
	select * from Departments
end
GO
