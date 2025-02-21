USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetRandomQuestions]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetRandomQuestions] 
    @mcqCount INT, 
    @TFcount INT,
    @courseId INT,
    @examId INT
AS
BEGIN
declare @QuestID int;
	insert into ExamQuestions select top (@TFcount) @examId , QuestionID 
    from QuestionPools 
    where QuestionType = 0 and CourseID = @courseId
    order by NEWID();
	----------
	insert into ExamQuestions select top (@mcqCount)  @examId , QuestionID
    from QuestionPools 
    where QuestionType = 1 and CourseID = @courseId
    order by NEWID();
END;
--------------------------------------------
GO
