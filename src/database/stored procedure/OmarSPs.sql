USE [iti_Exam]
GO
/****** Object:  StoredProcedure [dbo].[AddCourse]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddCourse] @crsName nvarchar(255)
as
begin
	insert into Courses values(@crsName)
end
GO
/****** Object:  StoredProcedure [dbo].[addCourseDepartment]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addCourseDepartment] @courseID int, @deptID int
as
begin
	insert into Course_Dept values(@courseID, @deptID)
end
GO
/****** Object:  StoredProcedure [dbo].[addCourseTopic]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addCourseTopic] @courseId int, @topicName nvarchar(255)
as
begin
	insert into CourseTopics values(@topicName, @courseId)
end
GO
/****** Object:  StoredProcedure [dbo].[addInstructorCourse]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addInstructorCourse] @crsid int, @instructorID int
as
begin
	insert into Instructor_Courses values(@crsid, @instructorID)
end
GO
/****** Object:  StoredProcedure [dbo].[AddNewBranch]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewBranch] 
    @branchName NVARCHAR(255)
AS
BEGIN
    -- Check if the branchName length is more than 2 characters
    IF LEN(@branchName) > 1
    BEGIN
        -- Insert into Branches only if the condition is met
        INSERT INTO Branches VALUES (@branchName)
    END
    ELSE
    BEGIN
        -- Optionally, you can raise an error or handle the case where the branch name is too short
        RAISERROR('Branch name must be at least 2 characters long.', 16, 1)
        RETURN; -- Optional: Exit the stored procedure
    END
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewDepartment]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddNewDepartment] @deptName nvarchar(255), @branchId int
as
begin
	IF LEN(@deptName) > 1
    BEGIN
        -- Insert into Branches only if the condition is met
        INSERT INTO Departments VALUES (@deptName, @branchId)
    END
    ELSE
    BEGIN
        -- Optionally, you can raise an error or handle the case where the branch name is too short
        RAISERROR('Branch name must be at least 2 characters long.', 16, 1)
        RETURN; -- Optional: Exit the stored procedure
    END
end
GO
/****** Object:  StoredProcedure [dbo].[changeCourseName]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[changeCourseName] @id int, @name nvarchar(255) 
as
begin
	update Courses set CourseName=@name where CourseID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteBranch] @id int
as
begin
	delete from Branches where BranchID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseDepartment]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCourseDepartment] @courseID int, @deptID int
as
begin
	delete from Course_Dept where CourseID=@courseID and DeptId=@deptID
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseInstructorByInstructorIDAndCourseID]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCourseInstructorByInstructorIDAndCourseID] @crsid int, @instructorID int
as
begin
	delete from Instructor_Courses
	where CourseID = @crsid and InstructorID=@instructorID
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseTopic]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteCourseTopic] @courseId int, @topicName nvarchar(255)
as
begin
	delete from CourseTopics where CourseID=@courseId and Topic = @topicName
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDepartmentById]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDepartmentById] @id int
as
begin
	delete from Departments where DeptID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllBranches]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllBranches]
as
begin
	select * from Branches
end
GO
/****** Object:  StoredProcedure [dbo].[getAllCourses]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllCourses] 
as
begin
	select * from Courses
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDepartments]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllDepartments]
as
begin
	select * from Departments
end
GO
/****** Object:  StoredProcedure [dbo].[getAllInstructors]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getAllInstructors]
as
begin
	select u.*
	from Instructors i inner join Users u
	on i.InstructorID = u.UserID
end
GO
/****** Object:  StoredProcedure [dbo].[getBranchByName]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getBranchByName] @name nvarchar(255)
as
begin
	select * from Branches where Lower(BranchName) = Lower(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[GetBrancheByID]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetBrancheByID] @branchId int
as
begin
	select * from Branches where BranchID = @branchId
end
GO
/****** Object:  StoredProcedure [dbo].[getBranchesDepartments]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getBranchesDepartments] @id int
as
begin
	select d.*
	from Branches b inner join Departments d
	on d.BranchID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[getBranchName]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getBranchName] @id int
as
begin
	select BranchName from Branches where BranchID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseByName]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getCourseByName] @name nvarchar(255)
as
begin
	select * from Courses where CourseName=@name
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartment]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourseDepartment] @courseID int, @deptID int
as
begin
	select * from Course_Dept where DeptId = @deptID and CourseID=@courseID
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartments]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourseDepartments] @id int
as
begin
	select * from Course_Dept where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartmentsAllInfo]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourseDepartmentsAllInfo] @courseId int
as
begin
	select d.* 
	from Course_Dept cp inner join Departments d
	on cp.DeptId = d.DeptID
	where CourseID=@courseId;
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructors]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourseInstructors] @id int
as
begin
	select * from Instructor_Courses where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructorsByCourseID]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getCourseInstructorsByCourseID] @id int
as
begin
	select * from Instructor_Courses 
	where CourseID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructorsInfo]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getCourseInstructorsInfo] @courseId nvarchar(255)
as
begin
	select i.*
	from Instructor_Courses ic inner join Users i
	on ic.InstructorID = i.UserID
	where ic.CourseID = @courseId
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseTopics]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourseTopics] @id int
as
begin
	select * from CourseTopics where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[GetDepartmentByNameAndBranchID]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDepartmentByNameAndBranchID] @name nvarchar(255), @id int
as
begin
	select * from Departments where LOWER(DeptName) = Lower(@name) and BranchID = @id 
end
GO
/****** Object:  StoredProcedure [dbo].[getInstructorsOfDepartments]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getInstructorsOfDepartments] @deptID int
as
begin
	select u.*
	from Branches b inner join Departments d
	on b.BranchID = d.BranchID
	inner join Instructors i
	on i.BranchID = b.BranchID
	inner join Users u
	on u.UserID=i.InstructorID
	where d.DeptID = @deptID
end
GO
/****** Object:  StoredProcedure [dbo].[getTopicByNameAndCourseID]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getTopicByNameAndCourseID] @courseId int, @topicName nvarchar(255)
as
begin
	select * from CourseTopics where CourseID=@courseId and Topic = @topicName
end
GO
/****** Object:  StoredProcedure [dbo].[updateBranchName]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateBranchName] @id int, @newName nvarchar(255)
as
begin
	update Branches set BranchName = @newName where BranchID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDepartment]    Script Date: 22/03/2024 03:06:46 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateDepartment] @deptId int, @deptName nvarchar(255), @BranchID int
as
begin
	update Departments set DeptName = @deptName, BranchID=@BranchID
	where DeptID = @deptId
end
GO
