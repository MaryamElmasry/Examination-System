USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getAllStudents]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getAllStudents]
as
begin
select * from Students
end
GO
