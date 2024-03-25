USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[getBranchByName]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[getBranchByName] @name nvarchar(255)
as
begin
	select * from Branches where Lower(BranchName) = Lower(@name)
end
GO
