create   proc [dbo].[GetAllDeptCoursesforIns] @deptid int , @insid int
as
begin
select c.CourseID , c.CourseName from Courses c join Course_Dept dc on
dc.CourseID = c.CourseID 
join Departments d on d.DeptID = dc.DeptId
join Instructor_Courses ic on ic.CourseID = c.CourseID
where d.DeptID = @deptid and ic.InstructorID = @insid
end
