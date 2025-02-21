USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddCourse]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[AddCourse] @crsName nvarchar(255)
as
begin
	insert into Courses values(@crsName)
end
GO
/****** Object:  StoredProcedure [dbo].[addCourseDepartment]    Script Date: 3/25/2024 8:10:10 PM ******/
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
/****** Object:  StoredProcedure [dbo].[addCourseTopic]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[addCourseTopic] @courseId int, @topicName nvarchar(255)
as
begin
	insert into CourseTopics values(@topicName, @courseId)
end
GO
/****** Object:  StoredProcedure [dbo].[addInstructorCourse]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[addInstructorCourse] @crsid int, @instructorID int
as
begin
	insert into Instructor_Courses values(@crsid, @instructorID)
end
GO
/****** Object:  StoredProcedure [dbo].[AddInstructorToCourse]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[AddInstructorToCourse]
    @CourseID INT,
    @InstructorID INT
AS
BEGIN
    -- Insert the new entry
    INSERT INTO Instructor_Courses (CourseID, InstructorID)
    VALUES (@CourseID, @InstructorID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewBranch]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[AddNewBranch] 
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
/****** Object:  StoredProcedure [dbo].[AddNewDepartment]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[AddNewDepartment] @deptName nvarchar(255), @branchId int
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
/****** Object:  StoredProcedure [dbo].[AddQuestion]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[AddQuestion] @qtext varchar(200) , @choice1 varchar(50),@choice2 varchar(50),@choice3 varchar(50),@choice4 varchar(50),@qtyep int,@CorrectIndex int,@Grade int , @CourseId int
as 
begin
	insert into QuestionPools values (@qtext,@qtyep,@CorrectIndex,@Grade,@CourseId);
		declare @QuestId int = IDENT_CURRENT('QuestionPools');
		if @qtyep = 1
		begin
		insert into QuestionChoices values(@choice1,@QuestId,1)
		insert into QuestionChoices values(@choice2,@QuestId,2)
		insert into QuestionChoices values(@choice3,@QuestId,3)
		insert into QuestionChoices values(@choice4,@QuestId,4)
		end
				if @qtyep = 0
				begin
				insert into QuestionChoices values('true',@QuestId,1)
				insert into QuestionChoices values('false',@QuestId,2)
				end
end
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStudent]
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES (@UserName, @Email, @Address, @Password, @Phone, @Gender)

    DECLARE @UserID INT
    SET @UserID = SCOPE_IDENTITY()

    INSERT INTO Students (StudentID, DeptID)
    VALUES (@UserID, @DeptID)
END
GO
/****** Object:  StoredProcedure [dbo].[AuthenticateUser]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[AuthenticateUser]
    @Email NVARCHAR(255),
    @Password NVARCHAR(255),
    @UserType NVARCHAR(50) OUTPUT,
    @UserID INT OUTPUT
AS
BEGIN
    SET @UserID  = (SELECT UserID FROM [Users] WHERE Email = @Email AND Password = @Password);
    
    IF @UserID IS NULL
    BEGIN
        SET @UserType = 'Invalid';
        SET @UserID = -1;
    END
    ELSE
    BEGIN
        IF EXISTS (SELECT 1 FROM [Students] WHERE StudentID = @UserID)
        BEGIN
            SET @UserType = 'Student';
        END
        ELSE
        BEGIN
            SET @UserType = 'Instructor';
        END
    END
END
GO
/****** Object:  StoredProcedure [dbo].[changeCourseName]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[changeCourseName] @id int, @name nvarchar(255) 
as
begin
	update Courses set CourseName=@name where CourseID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllDataFromTables]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAllDataFromTables]
AS
BEGIN
    DECLARE @tableName NVARCHAR(MAX)
    DECLARE tableCursor CURSOR FOR
        SELECT TABLE_NAME
        FROM INFORMATION_SCHEMA.TABLES
        WHERE TABLE_TYPE = 'BASE TABLE'
        AND TABLE_NAME NOT IN ('sysdiagrams') -- Exclude system tables if necessary

    OPEN tableCursor
    FETCH NEXT FROM tableCursor INTO @tableName

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'DELETE FROM ' + @tableName
        EXEC sp_executesql @sql

        FETCH NEXT FROM tableCursor INTO @tableName
    END

    CLOSE tableCursor
    DEALLOCATE tableCursor
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[DeleteBranch] @id int
as
begin
	delete from Branches where BranchID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseDepartment]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[deleteCourseDepartment] @courseID int, @deptID int
as
begin
	delete from Course_Dept where CourseID=@courseID and DeptId=@deptID
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseInstructorByInstructorIDAndCourseID]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[deleteCourseInstructorByInstructorIDAndCourseID] @crsid int, @instructorID int
as
begin
	delete from Instructor_Courses
	where CourseID = @crsid and InstructorID=@instructorID
end
GO
/****** Object:  StoredProcedure [dbo].[deleteCourseTopic]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[deleteCourseTopic] @courseId int, @topicName nvarchar(255)
as
begin
	delete from CourseTopics where CourseID=@courseId and Topic = @topicName
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDepartmentById]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[DeleteDepartmentById] @id int
as
begin
	delete from Departments where DeptID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[deleteExam]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------
CREATE   proc [dbo].[deleteExam] @eid int
as
begin
	delete Exams where ExamID = @eid
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteInstructor]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteInstructor]
    @UserID INT
AS
BEGIN
    DELETE FROM Instructors WHERE InstructorID = @UserID
    DELETE FROM Users WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[EditInstructor]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditInstructor]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateInstructor @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
    ELSE
    BEGIN
        EXEC AddInstructor @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[EditStudent]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditStudent]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateStudent @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
    ELSE
    BEGIN
        EXEC AddStudent @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ExamReport]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------
CREATE   proc [dbo].[ExamReport] @examid int
as
begin
select qp.Title , qc.Choice from Exams e join 
ExamQuestions eq on eq.ExamID = e.ExamID
join QuestionPools qp on qp.QuestionID = eq.QuestionID
join QuestionChoices qc on
qc.QuestionID = qp.QuestionID
where e.ExamID = @examid;
end
GO
/****** Object:  StoredProcedure [dbo].[GenerateExam]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------
CREATE   proc [dbo].[GenerateExam] @courseId int ,@deptId int, @date datetime , @mcqCount int, @TFcount int,@duration int
as
begin
declare @ExamId int;
SELECT @ExamId = IDENT_CURRENT('Exams') + 1
insert into Exams values(@date,@duration,@courseId,@deptId); 
exec GetRandomQuestions @mcqCount,@TFcount,@courseId,@ExamId
end
-----------------------------------
GO
/****** Object:  StoredProcedure [dbo].[GetAllBranches]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetAllBranches]
as
begin
	select * from Branches
end
GO
/****** Object:  StoredProcedure [dbo].[getAllCourses]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getAllCourses] 
as
begin
	select * from Courses
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllCoursesInBranchByInstructorID]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCoursesInBranchByInstructorID]
    @InstructorID INT
AS
BEGIN
    DECLARE @BranchID INT

    EXEC GetBranchIDByInstructorID @InstructorID, @BranchID OUTPUT

    SELECT DISTINCT Branches.BranchID, Courses.CourseID, Courses.CourseName 
    FROM Courses
    INNER JOIN Course_Dept ON Courses.CourseID = Course_Dept.CourseID
    INNER JOIN Departments ON Course_Dept.DeptId = Departments.DeptID
    INNER JOIN Branches ON Departments.BranchID = Branches.BranchID
    WHERE Branches.BranchID = @BranchID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllDepartments]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetAllDepartments]
as
begin
	select * from Departments
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllDeptCourses]    Script Date: 3/25/2024 8:10:10 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getAllExamQuestions]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getAllExamQuestions]
AS
BEGIN
    SELECT * FROM ExamQuestions;
END

GO
/****** Object:  StoredProcedure [dbo].[getAllExams]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllExams]
as
begin
select * from Exams
end
GO
/****** Object:  StoredProcedure [dbo].[getallinstructors]    Script Date: 3/25/2024 8:10:10 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getAllQuestionChoices]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[getAllQuestionChoices]
as
begin
select * from QuestionChoices
end

GO
/****** Object:  StoredProcedure [dbo].[getAllQuestionPools]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getAllQuestionPools]
as
begin
select * from QuestionPools
end

GO
/****** Object:  StoredProcedure [dbo].[GetAllQuestions]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetAllQuestions] @crsId int
as
begin
declare @Isselected bit = 0;
	select qp.QuestionID ,isSelected =  @Isselected  , qp.Title , qp.CorrectAnswerIndex , qp.Grade ,qc.Choice
		
	from QuestionPools qp join QuestionChoices qc 
	on qc.QuestionID = qp.QuestionID and qc.ChoiceIndex = qp.CorrectAnswerIndex
	where CourseID = @crsId 
end
-------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[getAllStudentExamQuestions]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- get all StudentExamQuestions
CREATE PROCEDURE [dbo].[getAllStudentExamQuestions]
AS
BEGIN
    SELECT * FROM StudentExamQuestions;
END
GO
/****** Object:  StoredProcedure [dbo].[getAllStudents]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getAllStudents]
as
begin
select * from Students
end
GO
/****** Object:  StoredProcedure [dbo].[getallusers]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getallusers]
as 
begin 
select * from Users
end
GO
/****** Object:  StoredProcedure [dbo].[getBranchByName]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getBranchByName] @name nvarchar(255)
as
begin
	select * from Branches where Lower(BranchName) = Lower(@name)
end
GO
/****** Object:  StoredProcedure [dbo].[GetBrancheByID]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetBrancheByID] @branchId int
as
begin
	select * from Branches where BranchID = @branchId
end
GO
/****** Object:  StoredProcedure [dbo].[getBranchesDepartments]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getBranchesDepartments] @id int
as
begin
	select d.*
	from Branches b inner join Departments d
	on d.BranchID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[GetBranchIDByInstructorID]    Script Date: 3/25/2024 8:10:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBranchIDByInstructorID]
    @InstructorID INT,
    @BranchID INT OUTPUT  -- Add output parameter for BranchID
AS
BEGIN
    SELECT @BranchID = BranchID
    FROM Instructors
    WHERE InstructorID = @InstructorID
END
GO
/****** Object:  StoredProcedure [dbo].[getBranchName]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getBranchName] @id int
as
begin
	select BranchName from Branches where BranchID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseByName]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getCourseByName] @name nvarchar(255)
as
begin
	select * from Courses where CourseName=@name
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartment]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartment] @courseID int, @deptID int
as
begin
	select * from Course_Dept where DeptId = @deptID and CourseID=@courseID
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartments]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartments] @id int
as
begin
	select * from Course_Dept where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseDepartmentsAllInfo]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseDepartmentsAllInfo] @courseId int
as
begin
	select d.* 
	from Course_Dept cp inner join Departments d
	on cp.DeptId = d.DeptID
	where CourseID=@courseId;
end
GO
/****** Object:  StoredProcedure [dbo].[GetCourseExams]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCourseExams]
    @DeptID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate,Exams.Duration
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    WHERE Exams.DeptID = @DeptID;
END;
GO
/****** Object:  StoredProcedure [dbo].[getCourseIdByExamID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getCourseIdByExamID]
	@ExamID int
As
 Select CourseID from Exams  Where ExamID=@ExamID
GO
/****** Object:  StoredProcedure [dbo].[GetCourseInfo]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCourseInfo]
    @CourseID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CourseName, ExamDate
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    WHERE Courses.CourseID = @CourseID;
END
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructors]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseInstructors] @id int
as
begin
	select * from Instructor_Courses where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructorsByCourseID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getCourseInstructorsByCourseID] @id int
as
begin
	select * from Instructor_Courses 
	where CourseID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[getCourseInstructorsInfo]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getCourseInstructorsInfo] @courseId nvarchar(255)
as
begin
	select i.*
	from Instructor_Courses ic inner join Users i
	on ic.InstructorID = i.UserID
	where ic.CourseID = @courseId
end
GO
/****** Object:  StoredProcedure [dbo].[GetCourseList]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[GetCourseList] @InsId INT
AS
BEGIN
    SELECT c.CourseName, c.CourseID
    FROM
        Courses	C
		inner join Instructor_Courses IC
		on c.CourseID = ic.CourseID
    WHERE
        Ic.InstructorID = @InsId
END
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByInstructorID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCoursesByInstructorID]
    @InstructorID INT
AS
BEGIN
    SELECT Courses.CourseID, Courses.CourseName
    FROM Courses
    INNER JOIN Instructor_Courses ON Courses.CourseID = Instructor_Courses.CourseID
    WHERE Instructor_Courses.InstructorID = @InstructorID
END
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesInBranch]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCoursesInBranch]
    @BranchID INT
AS
BEGIN
    SELECT DISTINCT Branches.BranchID, Courses.CourseID, Courses.CourseName 
    FROM Courses
    INNER JOIN Course_Dept ON Courses.CourseID = Course_Dept.CourseID
    INNER JOIN Departments ON Course_Dept.DeptId = Departments.DeptID
    INNER JOIN Branches ON Departments.BranchID = Branches.BranchID
    WHERE Branches.BranchID = @BranchID
END
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesIns]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetCoursesIns] @insId int
as
begin
select c.CourseID , CourseName from Courses c join Instructor_Courses ic on
ic.CourseID = c.CourseID
where ic.InstructorID = @insId
end
---------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[getCourseTopics]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getCourseTopics] @id int
as
begin
	select * from CourseTopics where CourseID=@id;
end
GO
/****** Object:  StoredProcedure [dbo].[GetDepartmentByNameAndBranchID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[GetDepartmentByNameAndBranchID] @name nvarchar(255), @id int
as
begin
	select * from Departments where LOWER(DeptName) = Lower(@name) and BranchID = @id 
end
GO
/****** Object:  StoredProcedure [dbo].[GetDeptsforIns]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetDeptsforIns] @insId int
as
begin
	select d.DeptName , d.DeptID,d.BranchID from Departments d join Branches b
	on d.BranchID = b.BranchID join Instructors I 
	on I.BranchID = b.BranchID
	where i.InstructorID = @insId
end
---------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[getExam]    Script Date: 3/25/2024 8:10:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getExambyId]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getExambyId] @id int
as
begin
	Select * from Exams where ExamID = @id
end
---------------------------------------
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetExamForStdReport]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[GetExamForStdReport]
    @ExamID INT,
    @StudentID INT
AS
BEGIN

    SELECT 
        qp.Title AS Question,
        qc.Choice AS [Correct Answer],
        qc_student.Choice AS StudentAnswer,
        CASE 
            WHEN seq.SelectedAnswerIndex = qp.CorrectAnswerIndex THEN 'Correct'
            ELSE 'Incorrect'
        END AS AnswerStatus
    FROM
		QuestionPools qp
    INNER JOIN 
		ExamQuestions eq ON eq.QuestionID = qp.QuestionID
    INNER JOIN 
        QuestionChoices qc ON eq.QuestionID = qc.QuestionID
                            AND qc.ChoiceIndex = qp.CorrectAnswerIndex
    INNER JOIN 
        StudentExamQuestions seq ON eq.ExamID = seq.ExamID
                                   AND eq.QuestionID = seq.QuestionID
                                   AND seq.StudentID = @StudentID
    LEFT JOIN 
        QuestionChoices qc_student ON seq.QuestionID = qc_student.QuestionID
                                      AND seq.SelectedAnswerIndex = qc_student.ChoiceIndex
    WHERE 
        eq.ExamID = @ExamID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetExamGradesByStudentID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetExamGradesByStudentID]
    @StudentID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate, StudentGrades.Grade
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    INNER JOIN StudentGrades ON Courses.CourseID = StudentGrades.CourseID
    WHERE StudentGrades.StudentID = @StudentID
END;
GO
/****** Object:  StoredProcedure [dbo].[GetExamInfo]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[GetExamInfo]
    @ExamId INT,
    @StdId INT
AS
BEGIN
    DECLARE @CourseName NVARCHAR(100)
    DECLARE @Grade FLOAT

    -- Retrieve Course Name
    SELECT @CourseName = c.CourseName
    FROM Exams ex
    INNER JOIN Courses c ON ex.CourseID = c.CourseID
    WHERE ExamID = @ExamId

    -- Retrieve Grade
    SELECT @Grade = sg.Grade
    FROM StudentGrades sg
    WHERE sg.CourseID = (SELECT CourseID FROM Exams WHERE ExamID = @ExamId)
    AND sg.StudentID = @StdId

    -- Return Course Name and Grade
    SELECT @CourseName AS CourseName, @Grade AS Grade
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamsDeptCourse]    Script Date: 3/25/2024 8:10:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetExamTable]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetExamTable]
AS
BEGIN
    SELECT CourseName, ExamDate
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
END
GO
/****** Object:  StoredProcedure [dbo].[GetGradesByStudentID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetGradesByStudentID]
    @StudentID INT
AS
BEGIN
    SELECT Courses.CourseName, StudentGrades.Grade
    FROM Courses
 
    INNER JOIN StudentGrades ON Courses.CourseID = StudentGrades.CourseID
    WHERE StudentGrades.StudentID = @StudentID
END;
GO
/****** Object:  StoredProcedure [dbo].[GetInstructorByid]    Script Date: 3/25/2024 8:10:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetInstructorsByBranchID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInstructorsByBranchID]
    @BranchID INT
AS
BEGIN
    SELECT Users.*
    FROM Instructors
    INNER JOIN Users ON Instructors.InstructorID = Users.UserID
    WHERE Instructors.BranchID = @BranchID;
END
GO
/****** Object:  StoredProcedure [dbo].[getInstructorsOfDepartments]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getInstructorsOfDepartments] @deptID int
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
/****** Object:  StoredProcedure [dbo].[GetQuestionChoices]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetQuestionChoices]
    @ExamID INT  
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        EQ.QuestionID,
        QP.Title,
        Choices = STRING_AGG(QC.Choice, ', ')
    FROM
        ExamQuestions EQ
    INNER JOIN
        QuestionPools QP ON EQ.QuestionID = QP.QuestionID
    INNER JOIN
        QuestionChoices QC ON EQ.QuestionID = QC.QuestionID
    WHERE EQ.ExamID = @ExamID  
    GROUP BY
        EQ.QuestionID,
        QP.Title;
END
GO
/****** Object:  StoredProcedure [dbo].[GetRandomQuestions]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetRandomQuestions] 
    @mcqCount INT, 
    @TFcount INT,
    @courseId INT,
    @examId INT
AS
BEGIN
declare @QuestID int;
	insert into ExamQuestions select top (@TFcount) @examId , QuestionID 
    from QuestionPools 
    where QuestionType = 0 and CourseID = @courseId
    order by NEWID();
	----------
	insert into ExamQuestions select top (@mcqCount)  @examId , QuestionID
    from QuestionPools 
    where QuestionType = 1 and CourseID = @courseId
    order by NEWID();
END;
--------------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[GetStudentExamDetails]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetStudentExamDetails]
    @StudentID INT,
    @ExamID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        QP.Title AS [Question Title],
        SEQ.SelectedAnswerIndex,
        QP.CorrectAnswerIndex,
        QP.Grade AS [Question Grade]
    FROM
        StudentExamQuestions SEQ
    INNER JOIN
        QuestionPools QP ON SEQ.QuestionID = QP.QuestionID
    WHERE 
        SEQ.StudentID = @StudentID 
        AND SEQ.ExamID = @ExamID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetStudentGrades]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentGrades]
    @StudentID INT,
    @ExamID INT,
	@CourseID INT

AS

    SET NOCOUNT ON;

    DECLARE @TotalGrade INT;
	DECLARE @StudentGrades INT;

    -- Fetch the student exam details using the GetStudentExamDetails stored procedure
    DECLARE @StudentExamDetails TABLE (
        [Question Title] NVARCHAR(200),
        [SelectedAnswerIndex] INT,
        [CorrectAnswerIndex] INT,
        [Question Grade] INT
    );

    INSERT INTO @StudentExamDetails EXEC [dbo].[GetStudentExamDetails] @StudentID, @ExamID;

    SELECT @StudentGrades = SUM(CASE WHEN SelectedAnswerIndex = CorrectAnswerIndex THEN [Question Grade] ELSE 0 END)
	 , @TotalGrade = SUM([Question Grade])
    FROM @StudentExamDetails;
    INSERT INTO [iti_exam].[dbo].[StudentGrades] ([CourseID], [StudentID], [Grade])
    VALUES (@CourseID, @StudentID, @StudentGrades);
    SELECT @StudentGrades AS [Student Grade], @TotalGrade AS [Total Grade] ;
GO
/****** Object:  StoredProcedure [dbo].[GetStudentName]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetStudentName]
    @studentID INT
AS
BEGIN
    SELECT UserName
    FROM Users
    WHERE UserID = @studentID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByDept]    Script Date: 3/25/2024 8:10:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetStudentsByDeptID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentsByDeptID]
    @DeptID INT
AS
BEGIN
    SELECT Users.*
    FROM Students
    INNER JOIN Users ON Students.StudentID = Users.UserID
    WHERE Students.DeptID = @DeptID;
END
GO
/****** Object:  StoredProcedure [dbo].[getStudentsPerCourse]    Script Date: 3/25/2024 8:10:11 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getTopicByNameAndCourseID]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getTopicByNameAndCourseID] @courseId int, @topicName nvarchar(255)
as
begin
	select * from CourseTopics where CourseID=@courseId and Topic = @topicName
end
GO
/****** Object:  StoredProcedure [dbo].[InitializeBranches]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeBranches]
AS
BEGIN
    INSERT INTO Branches (BranchName)
    VALUES ('Mansoura'), ('Smart Village'), ('New Capital');
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeCourses]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeCourses]
AS
BEGIN
    INSERT INTO Courses (CourseName)
    VALUES ('Python'), 
           ('Java'), 
           ('C++'), 
           ('JavaScript'), 
           ('HTML and CSS');
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeDepartments]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeDepartments]
AS
BEGIN
    INSERT INTO Departments (DeptName, BranchID)
    VALUES ('PD', 1), ('AI', 1), ('OS', 1); -- Assign Branch 1 to all departments
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeExamQuestions]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InitializeExamQuestions]
AS
BEGIN
    -- Insert exam questions
    INSERT INTO ExamQuestions (ExamID, QuestionID)
    VALUES 
        (0, 0),
        (0, 1),
        (0, 2),
        (0, 3),
        (0, 4),
        (0, 5),
        (0, 6),
        (0, 7),
        (0, 8),
        (0, 9);
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeExams]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeExams]
AS
BEGIN

    INSERT INTO Exams (ExamDate, Duration, CourseID, DeptID)
    VALUES ('2024-03-21', 120, 4, 1);
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeInstructors]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeInstructors]
AS
BEGIN
    -- Insert instructors with ID 4 and 5
    INSERT INTO Instructors (BranchID, InstructorID)
    VALUES (1, 4), (1, 5);
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeQuestionChoices]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InitializeQuestionChoices]
AS
BEGIN
    -- Insert choices for each question

    -- Question 0: What is JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('JavaScript is a scripting language.', 0, 0),
           ('JavaScript is a markup language.', 0, 1),
           ('JavaScript is a programming language.', 0, 2),
           ('JavaScript is a styling language.', 0, 3);
    
    -- Question 1: What are the data types in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Number', 1, 0),
           ('String', 1, 1),
           ('Boolean', 1, 2),
           ('All of the above', 1, 3);

    -- Question 2: What is the purpose of the "use strict" directive in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('To enable strict mode, which catches common coding mistakes and "unsafe" actions.', 2, 0),
           ('To enable lax mode, which relaxes the rules of JavaScript.', 2, 1),
           ('To enable experimental mode, which enables experimental JavaScript features.', 2, 2),
           ('To enable debug mode, which allows debugging JavaScript code.', 2, 3);

    -- Question 3: What is event bubbling in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Event bubbling is the propagation of an event from the target element to its ancestors in the DOM hierarchy.', 3, 0),
           ('Event bubbling is the propagation of an event from the ancestor elements to the target element in the DOM hierarchy.', 3, 1),
           ('Event bubbling is the propagation of an event in a circular manner between elements.', 3, 2),
           ('Event bubbling is the propagation of an event from the sibling elements to the target element in the DOM hierarchy.', 3, 3);

    -- Question 4: What is the difference between == and === in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('== checks only for equality in value, whereas === checks for both value and data type.', 4, 0),
           ('== checks for both value and data type, whereas === checks only for equality in value.', 4, 1),
           ('== and === are completely interchangeable.', 4, 2),
           ('== and === are both used for assigning values in JavaScript.', 4, 3);

    -- Question 5: What is the result of 2 + 2 in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('3', 5, 0),
           ('4', 5, 1),
           ('6', 5, 2),
           ('8', 5, 3);

    -- Question 6: How do you declare a variable in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('let myVar = value;', 6, 0),
           ('var myVar = value;', 6, 1),
           ('const myVar = value;', 6, 2),
           ('Both var and let are correct.', 6, 3);

    -- Question 7: What does NaN stand for?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Negative and Null', 7, 0),
           ('Not a Number', 7, 1),
           ('New and Navigable', 7, 2),
           ('None of the above', 7, 3);

    -- Question 8: How do you write "Hello World" in an alert box?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('alert("Hello World");', 8, 0),
           ('prompt("Hello World");', 8, 1),
           ('confirm("Hello World");', 8, 2),
           ('console.log("Hello World");', 8, 3);

    -- Question 9: What is the output of console.log(typeof []); in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('object', 9, 0),
           ('array', 9, 1),
           ('string', 9, 2),
           ('undefined', 9, 3);

    -- Question 10: What is the purpose of the document.getElementById() method in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('To get the value of an element by its class name.', 10, 0),
           ('To get the value of an element by its ID.', 10, 1),
           ('To get the value of an element by its tag name.', 10, 2),
           ('To get the value of an element by its name attribute.', 10, 3);

    -- Question 11: What does the && operator do in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Logical OR', 11, 0),
           ('Logical AND', 11, 1),
           ('Bitwise OR', 11, 2),
           ('Bitwise AND', 11, 3);

    -- Question 12: What does the || operator do in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Logical OR', 12, 0),
           ('Logical AND', 12, 1),
           ('Bitwise OR', 12, 2),
           ('Bitwise AND', 12, 3);

    -- Question 13: What does the typeof operator return in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('The type of a variable or expression.', 13, 0),
           ('The value of a variable or expression.', 13, 1),
           ('The size of a variable or expression.', 13, 2),
           ('The length of a variable or expression.', 13, 3);

    -- Question 14: How do you round the number 7.25 to the nearest integer in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Math.ceil(7.25)', 14, 0),
           ('Math.round(7.25)', 14, 1),
           ('Math.floor(7.25)', 14, 2),
           ('round(7.25)', 14, 3);

    -- Question 15: What is the correct way to write a JavaScript array?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('var colors = "red", "green", "blue";', 15, 0),
           ('var colors = ["red", "green", "blue"];', 15, 1),
           ('var colors = {"red", "green", "blue"};', 15, 2),
           ('var colors = ("red", "green", "blue");', 15, 3);

    -- Question 16: Which event occurs when the user clicks on an HTML element in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('onmouseover', 16, 0),
           ('onmouseout', 16, 1),
           ('onclick', 16, 2),
           ('onchange', 16, 3);

    -- Question 17: How do you add a comment in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('/* This is a comment */', 17, 0),
           ('// This is a comment', 17, 1),
           ('<-- This is a comment -->', 17, 2),
           ('<!-- This is a comment -->', 17, 3);

    -- Question 18: What is the output of console.log(1 + "1" + 1); in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('3', 18, 0),
           ('111', 18, 1),
           ('2', 18, 2),
           ('11', 18, 3);

    -- Question 19: What is the result of 10 > 9 in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('true', 19, 0),
           ('false', 19, 1),
           ('10', 19, 2),
           ('9', 19, 3);


END

GO
/****** Object:  StoredProcedure [dbo].[InitializeQuestionPools]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeQuestionPools]
AS
BEGIN
    INSERT INTO QuestionPools (Title, QuestionType, CorrectAnswerIndex, Grade, CourseID)
    VALUES 
        ('What is JavaScript?', 1, 0, 10, 4),
        ('What are the data types in JavaScript?', 1, 2, 10, 4),
        ('What is the purpose of the "use strict" directive in JavaScript?', 1, 1, 10, 4),
        ('What is event bubbling in JavaScript?', 1, 3, 10, 4),
        ('What is the difference between == and === in JavaScript?', 1, 0, 10, 4),
        ('What is the result of 2 + 2 in JavaScript?', 1, 3, 10, 4),
        ('How do you declare a variable in JavaScript?', 1, 2, 10, 4),
        ('What does NaN stand for?', 1, 0, 10, 4),
        ('How do you write "Hello World" in an alert box?', 1, 1, 10, 4),
        ('What is the output of console.log(typeof []); in JavaScript?', 1, 3, 10, 4),
        ('What is the purpose of the document.getElementById() method in JavaScript?', 1, 2, 10, 4),
        ('What does the && operator do in JavaScript?', 1, 1, 10, 4),
        ('What does the || operator do in JavaScript?', 1, 2, 10, 4),
        ('What does the typeof operator return in JavaScript?', 1, 3, 10, 4),
        ('How do you round the number 7.25 to the nearest integer in JavaScript?', 1, 0, 10, 4),
        ('What is the correct way to write a JavaScript array?', 1, 3, 10, 4),
        ('Which event occurs when the user clicks on an HTML element in JavaScript?', 1, 1, 10, 4),
        ('How do you add a comment in JavaScript?', 1, 2, 10, 4),
        ('What is the output of console.log(1 + "1" + 1); in JavaScript?', 1, 0, 10, 4),
        ('What is the result of 10 > 9 in JavaScript?', 1, 3, 10, 4);
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeStudentExamQuestions]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeStudentExamQuestions]
AS
BEGIN
    INSERT INTO StudentExamQuestions (SelectedAnswerIndex, ExamID, QuestionID, StudentID)
    VALUES (1, 0, 0, 1),
           (2, 0, 1, 1),
           (1, 0, 2, 1),
           (2, 0, 3, 1); 
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeStudents]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeStudents]
AS
BEGIN

    INSERT INTO Students (DeptID, StudentID)
    VALUES (1, 1), (1, 2); 
END
GO
/****** Object:  StoredProcedure [dbo].[InitializeUsers]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeUsers]
AS
BEGIN
    -- Insert users with the same password '123'
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES ('Ahmed', 'ahmed@example.com', 'Address1', '123', '1234567890', 'M'),
           ('Maryam', 'maryam@example.com', 'Address2', '123', '0987654321', 'F'),
           ('Omar', 'omar@example.com', 'Address3', '123', '9876543210', 'M'),
           ('Abdo', 'abdo@example.com', 'Address4', '123', '0123456789', 'M'),
           ('Saber', 'saber@example.com', 'Address5', '123', '5678901234', 'M');
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrUpdateSelectedAnswerIndex]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrUpdateSelectedAnswerIndex]
    @StudentID INT,
    @ExamID INT,
    @QuestionID INT,
    @SelectedAnswerIndex INT
AS
BEGIN
    BEGIN TRANSACTION;

    -- Check if the record already exists
    IF EXISTS (SELECT 1 FROM StudentExamQuestions WHERE StudentID = @StudentID AND ExamID = @ExamID AND QuestionID = @QuestionID)
    BEGIN
        -- Update the existing record
        UPDATE StudentExamQuestions
        SET SelectedAnswerIndex = @SelectedAnswerIndex
        WHERE StudentID = @StudentID AND ExamID = @ExamID AND QuestionID = @QuestionID;
    END
    ELSE
    BEGIN
        -- Insert a new record
        INSERT INTO StudentExamQuestions (StudentID, ExamID, QuestionID, SelectedAnswerIndex)
        VALUES (@StudentID, @ExamID, @QuestionID, @SelectedAnswerIndex);
    END

    COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertSelectedAnswerIndex]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertSelectedAnswerIndex]
    @StudentID INT,
    @ExamID INT,
    @QuestionID INT,
    @SelectedAnswerIndex INT
AS
BEGIN
    INSERT INTO StudentExamQuestions (SelectedAnswerIndex, ExamID, QuestionID, StudentID)
    VALUES (@SelectedAnswerIndex, @ExamID, @QuestionID, @StudentID);
END
GO
/****** Object:  StoredProcedure [dbo].[RemoveInstructorCourses]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveInstructorCourses]
    @InstructorID INT
AS
BEGIN
    -- Delete the entry
    DELETE FROM Instructor_Courses WHERE  InstructorID = @InstructorID
END
GO
/****** Object:  StoredProcedure [dbo].[RemoveInstructorFromCourse]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored procedure to remove an instructor from a course
CREATE PROCEDURE [dbo].[RemoveInstructorFromCourse]
    @CourseID INT,
    @InstructorID INT
AS
BEGIN
    -- Delete the entry
    DELETE FROM Instructor_Courses WHERE CourseID = @CourseID AND InstructorID = @InstructorID
END
GO
/****** Object:  StoredProcedure [dbo].[Reseed]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reseed]
AS
BEGIN
    EXEC sp_MSforeachtable 'DBCC CHECKIDENT (''?'', RESEED, 0)'
END
GO
/****** Object:  StoredProcedure [dbo].[updateBranchName]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[updateBranchName] @id int, @newName nvarchar(255)
as
begin
	update Branches set BranchName = @newName where BranchID=@id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDepartment]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[UpdateDepartment] @deptId int, @deptName nvarchar(255), @BranchID int
as
begin
	update Departments set DeptName = @deptName, BranchID=@BranchID
	where DeptID = @deptId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateInstructor]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInstructor]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    UPDATE Users
    SET UserName = @UserName,
        Email = @Email,
        Address = @Address,
        Password = @Password,
        Phone = @Phone,
        Gender = @Gender
    WHERE UserID = @UserID

    UPDATE Instructors
    SET BranchID = @BranchID
    WHERE InstructorID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 3/25/2024 8:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateStudent]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    UPDATE Users
    SET UserName = @UserName,
        Email = @Email,
        Address = @Address,
        Password = @Password,
        Phone = @Phone,
        Gender = @Gender
    WHERE UserID = @UserID

    UPDATE Students
    SET DeptID = @DeptID
    WHERE StudentID = @UserID
END
GO
CREATE PROCEDURE getStudentsInfobydeptid
    @DeptID INT
AS
BEGIN
    SELECT Users.UserID, Users.UserName, Users.Email, Users.Address, Branches.BranchName, Departments.DeptName, Users.Phone, Users.Gender
    FROM Branches
    INNER JOIN Departments ON Branches.BranchID = Departments.BranchID
    INNER JOIN Students ON Departments.DeptID = Students.DeptID
    INNER JOIN Users ON Students.StudentID = Users.UserID
    WHERE Departments.DeptID = @DeptID;
END;
GO
create   proc [dbo].[GetAllDeptCoursesforIns] @deptid int , @insid int
as
begin
select c.CourseID , c.CourseName from Courses c join Course_Dept dc on
dc.CourseID = c.CourseID 
join Departments d on d.DeptID = dc.DeptId
join Instructor_Courses ic on ic.CourseID = c.CourseID
where d.DeptID = @deptid and ic.InstructorID = @insid
end
create or alter PROCEDURE AddStudent
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES (@UserName, @Email, @Address, @Password, @Phone, @Gender)

    DECLARE @UserID INT
    SET @UserID = SCOPE_IDENTITY()

    INSERT INTO Students (StudentID, DeptID)
    VALUES (@UserID, @DeptID)
END
go
create or alter PROCEDURE UpdateStudent
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    UPDATE Users
    SET UserName = @UserName,
        Email = @Email,
        Address = @Address,
        Password = @Password,
        Phone = @Phone,
        Gender = @Gender
    WHERE UserID = @UserID

    UPDATE Students
    SET DeptID = @DeptID
    WHERE StudentID = @UserID
END
go
create or alter PROCEDURE EditStudent
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateStudent @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
    ELSE
    BEGIN
        EXEC AddStudent @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
END
gO
create or alter PROCEDURE DeleteStudent
    @UserID INT
AS
BEGIN
    DELETE FROM Students WHERE StudentID = @UserID
    DELETE FROM Users WHERE UserID = @UserID
END
go
create or alter PROCEDURE GetAllStudents
AS
BEGIN
    SELECT Users.UserID, Users.UserName, Users.Email, Users.Address, Users.Phone, Users.Gender, Students.DeptID
    FROM Students
    INNER JOIN Users ON Students.StudentID = Users.UserID
END

Exec GetAllStudents
SELECT Instructors.BranchID, Users.UserID, Users.UserName, Users.Email, Users.Address, Users.Password, Users.Phone, Users.Gender
FROM   Instructors INNER JOIN
             Users ON Instructors.InstructorID = Users.UserID

go
create or alter PROCEDURE AddInstructor
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES (@UserName, @Email, @Address, @Password, @Phone, @Gender)

    DECLARE @UserID INT
    SET @UserID = SCOPE_IDENTITY()

    INSERT INTO Instructors (InstructorID, BranchID)
    VALUES (@UserID, @BranchID)
END
Go
create or alter PROCEDURE UpdateInstructor
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    UPDATE Users
    SET UserName = @UserName,
        Email = @Email,
        Address = @Address,
        Password = @Password,
        Phone = @Phone,
        Gender = @Gender
    WHERE UserID = @UserID

    UPDATE Instructors
    SET BranchID = @BranchID
    WHERE InstructorID = @UserID
END
Go
create or alter PROCEDURE EditInstructor
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateInstructor @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
    ELSE
    BEGIN
        EXEC AddInstructor @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
END
Go
create or alter PROCEDURE DeleteInstructor
    @UserID INT
AS
BEGIN
    DELETE FROM Instructors WHERE InstructorID = @UserID
    DELETE FROM Users WHERE UserID = @UserID
END
Go
create or alter PROCEDURE GetAllInstructors
AS
BEGIN
    SELECT Instructors.BranchID, Users.UserID, Users.UserName, Users.Email, Users.Address, Users.Phone, Users.Gender
    FROM Instructors
    INNER JOIN Users ON Instructors.InstructorID = Users.UserID
END
go
create or alter PROCEDURE GetStudentByEmail
    @Email NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Students
    INNER JOIN Users ON Students.StudentID = Users.UserID
    WHERE Users.Email = @Email
END
go
create or alter PROCEDURE GetInstructorByEmail
    @Email NVARCHAR(50)
AS
BEGIN
    SELECT Users.UserID, Users.UserName, Users.Email, Users.Address, Users.Phone, Users.Gender, Instructors.BranchID
    FROM Instructors
    INNER JOIN Users ON Instructors.InstructorID = Users.UserID
    WHERE Users.Email = @Email
END
go
create or alter PROCEDURE GetStudentsByDeptID
    @DeptID INT
AS
BEGIN
    SELECT Users.*
    FROM Students
    INNER JOIN Users ON Students.StudentID = Users.UserID
    WHERE Students.DeptID = @DeptID;
END
go
create or alter PROCEDURE GetInstructorsByBranchID
    @BranchID INT
AS
BEGIN
    SELECT Users.*
    FROM Instructors
    INNER JOIN Users ON Instructors.InstructorID = Users.UserID
    WHERE Instructors.BranchID = @BranchID;
END
go
create or alter PROCEDURE GetUserByEmail
    @Email NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Users
    WHERE Email = @Email;
END
go
CREATE OR ALTER PROCEDURE getUserByEmail_edit
 @UserId INT,
 @Email NVARCHAR(50)

   
AS
BEGIN
    SELECT *
    FROM Users
    WHERE Email = @Email
    AND UserId != @UserId; -- Exclude the specified user ID
END;
