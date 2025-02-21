USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GenerateExam]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------
CREATE   proc [dbo].[GenerateExam] @courseId int ,@deptId int, @date datetime , @mcqCount int, @TFcount int,@duration int
as
begin
declare @ExamId int;
SELECT @ExamId = IDENT_CURRENT('Exams') + 1
insert into Exams values(@date,@duration,@courseId,@deptId); 
exec GetRandomQuestions @mcqCount,@TFcount,@courseId,@ExamId
end
-----------------------------------
GO
