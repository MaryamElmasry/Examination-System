USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getExam]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getExam] @deptid int  , @crsid int
as
begin
	select * from Exams where DeptID = @deptid and CourseID = @crsid
end
----------------------------------------
GO
