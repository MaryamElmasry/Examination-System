USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getBranchName]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[getBranchName] @id int
as
begin
	select BranchName from Branches where BranchID=@id
end
GO
