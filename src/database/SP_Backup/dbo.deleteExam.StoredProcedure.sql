USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[deleteExam]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------
CREATE   proc [dbo].[deleteExam] @eid int
as
begin
	delete Exams where ExamID = @eid
end
GO
