USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetExamInfo]    Script Date: 3/25/2024 8:06:24 PM ******/
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
