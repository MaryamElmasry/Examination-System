USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesInBranch]    Script Date: 3/25/2024 8:06:23 PM ******/
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
