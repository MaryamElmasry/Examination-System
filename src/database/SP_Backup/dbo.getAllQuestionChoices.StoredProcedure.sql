USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getAllQuestionChoices]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[getAllQuestionChoices]
as
begin
select * from QuestionChoices
end

GO
