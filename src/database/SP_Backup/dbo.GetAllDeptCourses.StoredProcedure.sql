USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetAllDeptCourses]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetAllDeptCourses] @deptid int
as
begin
select c.CourseID , c.CourseName from Courses c join Course_Dept dc on
dc.CourseID = c.CourseID 
join Departments d on d.DeptID = dc.DeptId
where d.DeptID = @deptid 
end
----------------------------------
GO
