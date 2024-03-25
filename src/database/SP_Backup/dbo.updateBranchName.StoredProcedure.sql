USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[updateBranchName]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[updateBranchName] @id int, @newName nvarchar(255)
as
begin
	update Branches set BranchName = @newName where BranchID=@id
end
GO
