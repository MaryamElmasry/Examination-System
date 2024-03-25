USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeExamQuestions]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InitializeExamQuestions]
AS
BEGIN
    -- Insert exam questions
    INSERT INTO ExamQuestions (ExamID, QuestionID)
    VALUES 
        (0, 0),
        (0, 1),
        (0, 2),
        (0, 3),
        (0, 4),
        (0, 5),
        (0, 6),
        (0, 7),
        (0, 8),
        (0, 9);
END
GO
