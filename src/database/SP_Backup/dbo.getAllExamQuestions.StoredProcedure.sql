USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getAllExamQuestions]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getAllExamQuestions]
AS
BEGIN
    SELECT * FROM ExamQuestions;
END

GO
