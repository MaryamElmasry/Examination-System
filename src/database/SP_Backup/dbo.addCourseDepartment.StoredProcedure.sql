USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[addCourseDepartment]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[addCourseDepartment] @courseID int, @deptID int
as
begin
	insert into Course_Dept values(@courseID, @deptID)
end
GO
