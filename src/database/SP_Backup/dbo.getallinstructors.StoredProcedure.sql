USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getallinstructors]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getallinstructors]
as
begin
	select u.*
	from Instructors i inner join Users u
	on i.InstructorID = u.UserID
end
GO
