USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getCourseIdByExamID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getCourseIdByExamID]
	@ExamID int
As
 Select CourseID from Exams  Where ExamID=@ExamID
GO
