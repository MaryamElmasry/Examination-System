USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getTopicByNameAndCourseID]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getTopicByNameAndCourseID] @courseId int, @topicName nvarchar(255)
as
begin
	select * from CourseTopics where CourseID=@courseId and Topic = @topicName
end
GO
