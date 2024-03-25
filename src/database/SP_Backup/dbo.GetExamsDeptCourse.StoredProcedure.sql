USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetExamsDeptCourse]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetExamsDeptCourse] @crsid int , @deptid int 
as
begin
select e.ExamID , e.ExamDate , e.Duration from Exams e
where e.CourseID = @crsid and e.DeptID = @deptid
end
--------------------------------------
GO
