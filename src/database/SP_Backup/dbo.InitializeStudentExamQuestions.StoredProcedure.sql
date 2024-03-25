USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeStudentExamQuestions]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeStudentExamQuestions]
AS
BEGIN
    INSERT INTO StudentExamQuestions (SelectedAnswerIndex, ExamID, QuestionID, StudentID)
    VALUES (1, 0, 0, 1),
           (2, 0, 1, 1),
           (1, 0, 2, 1),
           (2, 0, 3, 1); 
END
GO
