USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InsertOrUpdateSelectedAnswerIndex]    Script Date: 3/25/2024 8:06:24 PM ******/
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
