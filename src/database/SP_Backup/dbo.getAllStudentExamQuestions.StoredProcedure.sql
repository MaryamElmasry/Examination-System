USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getAllStudentExamQuestions]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- get all StudentExamQuestions
CREATE PROCEDURE [dbo].[getAllStudentExamQuestions]
AS
BEGIN
    SELECT * FROM StudentExamQuestions;
END
GO
