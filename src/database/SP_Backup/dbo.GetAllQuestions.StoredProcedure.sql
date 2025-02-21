USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetAllQuestions]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[GetAllQuestions] @crsId int
as
begin
declare @Isselected bit = 0;
	select qp.QuestionID ,isSelected =  @Isselected  , qp.Title , qp.CorrectAnswerIndex , qp.Grade ,qc.Choice
		
	from QuestionPools qp join QuestionChoices qc 
	on qc.QuestionID = qp.QuestionID and qc.ChoiceIndex = qp.CorrectAnswerIndex
	where CourseID = @crsId 
end
-------------------------------------
GO
