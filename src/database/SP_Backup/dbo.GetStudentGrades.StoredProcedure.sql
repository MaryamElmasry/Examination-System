USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentGrades]    Script Date: 3/25/2024 8:06:24 PM ******/
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
