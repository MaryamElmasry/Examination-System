USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetInstructorByid]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetInstructorByid] @id int
as
begin
	select u.UserName , b.BranchName from Instructors I join Users u 
	on u.UserID = I.InstructorID join Branches b
	on b.BranchID = I.BranchID where I.InstructorID = @id
end
---------------------------------------
GO
