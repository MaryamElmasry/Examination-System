USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getExambyId]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getExambyId] @id int
as
begin
	Select * from Exams where ExamID = @id
end
---------------------------------------
SET QUOTED_IDENTIFIER ON
GO
