USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InsertSelectedAnswerIndex]    Script Date: 3/25/2024 8:06:24 PM ******/
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
