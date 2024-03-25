USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByDept]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetStudentsByDept] @deptid int
as
begin
select u.UserID , u.UserName , u.Email from Users u join Students s
on u.UserID = s.StudentID where s.DeptID = @deptid
end
-----------------------------------------------
GO
