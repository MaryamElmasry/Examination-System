USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionChoices]    Script Date: 3/25/2024 8:06:24 PM ******/
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
