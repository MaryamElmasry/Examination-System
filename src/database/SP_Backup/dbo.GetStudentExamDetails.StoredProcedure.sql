USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentExamDetails]    Script Date: 3/25/2024 8:06:24 PM ******/
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
