USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddQuestion]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[AddQuestion] @qtext varchar(200) , @choice1 varchar(50),@choice2 varchar(50),@choice3 varchar(50),@choice4 varchar(50),@qtyep int,@CorrectIndex int,@Grade int , @CourseId int
as 
begin
	insert into QuestionPools values (@qtext,@qtyep,@CorrectIndex,@Grade,@CourseId);
		declare @QuestId int = IDENT_CURRENT('QuestionPools');
		if @qtyep = 1
		begin
		insert into QuestionChoices values(@choice1,@QuestId,1)
		insert into QuestionChoices values(@choice2,@QuestId,2)
		insert into QuestionChoices values(@choice3,@QuestId,3)
		insert into QuestionChoices values(@choice4,@QuestId,4)
		end
				if @qtyep = 0
				begin
				insert into QuestionChoices values('true',@QuestId,1)
				insert into QuestionChoices values('false',@QuestId,2)
				end
end
GO
