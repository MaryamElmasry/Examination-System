USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddCourse]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[AddCourse] @crsName nvarchar(255)
as
begin
	insert into Courses values(@crsName)
end
GO
