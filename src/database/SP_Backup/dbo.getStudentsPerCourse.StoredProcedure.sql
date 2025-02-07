USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getStudentsPerCourse]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getStudentsPerCourse] @insid int
as
begin
	select count(StudentID) as [Number of students] , c.CourseName from Students s join Departments d
	on d.DeptID = s.DeptID join Branches B on
	b.BranchID = d.BranchID join Instructors I
	on I.BranchID = b.BranchID join Instructor_Courses ic
	on ic.InstructorID = i.InstructorID join Courses c
	on c.CourseID = ic.CourseID
	where I.InstructorID = @insid
	 group by c.CourseName
	
	
end
GO
