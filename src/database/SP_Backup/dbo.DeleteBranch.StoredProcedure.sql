USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranch]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[DeleteBranch] @id int
as
begin
	delete from Branches where BranchID = @id
end
GO
