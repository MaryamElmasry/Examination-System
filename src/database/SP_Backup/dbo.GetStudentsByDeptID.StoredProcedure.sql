USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentsByDeptID]    Script Date: 3/25/2024 8:06:24 PM ******/
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
