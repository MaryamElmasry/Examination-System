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


EXEC [dbo].[GetQuestionChoices] @ExamID = 5;