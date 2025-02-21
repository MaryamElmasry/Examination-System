USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[ExamReport]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------
CREATE   proc [dbo].[ExamReport] @examid int
as
begin
select qp.Title , qc.Choice from Exams e join 
ExamQuestions eq on eq.ExamID = e.ExamID
join QuestionPools qp on qp.QuestionID = eq.QuestionID
join QuestionChoices qc on
qc.QuestionID = qp.QuestionID
where e.ExamID = @examid;
end
GO
