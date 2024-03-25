USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getBranchesDepartments]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getBranchesDepartments] @id int
as
begin
	select d.*
	from Branches b inner join Departments d
	on d.BranchID = @id
end
GO
