USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetExamForStdReport]    Script Date: 3/25/2024 8:06:23 PM ******/
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
