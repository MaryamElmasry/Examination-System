USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeBranches]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeBranches]
AS
BEGIN
    INSERT INTO Branches (BranchName)
    VALUES ('Mansoura'), ('Smart Village'), ('New Capital');
END
GO
